#region license
// Transformalize
// Configurable Extract, Transform, and Load
// Copyright 2013-2017 Dale Newman
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//       http://www.apache.org/licenses/LICENSE-2.0
//   
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion
using System;
using System.Collections.Generic;
using Humanizer;
using Humanizer.Bytes;
using Transformalize.Configuration;
using Transformalize.Contracts;

namespace Transformalize.Transforms.Humanizer {
   public class BitsTransform : BaseTransform {

      private readonly Field _input;
      private readonly Func<object, ByteSize> _transform;

      public BitsTransform(IContext context = null) : base(context, "bytesize") {

         if (IsMissingContext()) {
            return;
         }

         if (IsNotReceivingNumber()) {
            return;
         }

         _input = SingleInput();

         switch (_input.Type) {
            case "byte":
               _transform = (o) => ((byte)o).Bits();
               break;
            case "short":
            case "int16":
               _transform = (o) => ((short)o).Bits();
               break;
            case "int":
            case "int32":
               _transform = (o) => ((int)o).Bits();
               break;
            case "double":
               _transform = (o) => Convert.ToInt64(o).Bits();
               break;
            case "long":
            case "int64":
               _transform = (o) => ((long)o).Bits();
               break;
            case "byte[]":
               _transform = (o) => ((byte[])o).Length.Bits();
               break;
            default:
               _transform = (o) => Convert.ToInt64(o).Bits();
               break;
         }

      }

      public override IRow Operate(IRow row) {
         row[Context.Field] = _transform(row[_input]);
         return row;
      }

      public override IEnumerable<OperationSignature> GetSignatures() {
         return new[] { new OperationSignature("bits") };
      }


   }
}