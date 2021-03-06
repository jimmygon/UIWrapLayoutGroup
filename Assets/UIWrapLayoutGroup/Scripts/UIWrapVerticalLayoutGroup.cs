﻿namespace Kiwi.JimmyGon
{
    public class UIWrapVerticalLayoutGroup : UIWrapHorizontalOrVerticalLayoutGroup
    {
        protected UIWrapVerticalLayoutGroup() { }

        public override void CalculateLayoutInputHorizontal()
        {
            base.CalculateLayoutInputHorizontal();
            CalcAlongAxis(0, true);
        }

        public override void CalculateLayoutInputVertical()
        {
            CalcAlongAxis(1, true);
        }

        public override void SetLayoutHorizontal()
        {
            SetChildrenAlongAxis(0, true);
        }

        public override void SetLayoutVertical()
        {
            SetChildrenAlongAxis(1, true);
        }
    }
}
