using System.Collections.Generic;
using UnityEngine.VFX;

namespace UnityEditor.VFX
{
    class VFXExpressionStripTangent : VFXExpression
    {
        public VFXExpressionStripTangent() : base(VFXExpression.Flags.PerElement | VFXExpression.Flags.InvalidOnCPU) { }

        public override VFXValueType valueType => VFXValueType.Float3;
        public override VFXExpressionOperation operation => VFXExpressionOperation.None;

        public override string GetCodeString(string[] parents)
        {
            return string.Format("GetStripTangent(attributes.position, relativeIndexInStrip, stripData)");
        }
<<<<<<< HEAD
    
=======

>>>>>>> 30e14a2ca18f7c4c9903767895c1ca15d1af6c76
        public override IEnumerable<VFXAttributeInfo> GetNeededAttributes()
        {
            yield return new VFXAttributeInfo(VFXAttribute.Position, VFXAttributeMode.Read);
        }
    }
}
