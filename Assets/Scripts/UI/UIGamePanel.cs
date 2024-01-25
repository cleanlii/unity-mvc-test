using UnityEngine;
using UnityEngine.UI;
using QFramework;
using System;

namespace ProjectPackage
{
    public class UIGamePanelData : UIPanelData
    {
    }
    public partial class UIGamePanel : UIPanel
    {
        protected override void OnInit(IUIData uiData = null)
        {
            mData = uiData as UIGamePanelData ?? new UIGamePanelData();

            GlobalManager.testTitle.RegisterWithInitValue(title =>
            {
                TestTitle.text = "Test Title: " + title;
            }).UnRegisterWhenGameObjectDestroyed(gameObject);

            GlobalManager.testData.RegisterWithInitValue(dataValue =>
            {
                TestData.text = "Test Data: " + dataValue;
            }).UnRegisterWhenGameObjectDestroyed(gameObject);

            GlobalManager.testBool.RegisterWithInitValue(boolValue =>
            {
                TestBool.text = "Test Bool Data: " + boolValue;
            }).UnRegisterWhenGameObjectDestroyed(gameObject);

        }

        protected override void OnOpen(IUIData uiData = null)
        {
        }

        protected override void OnShow()
        {
        }

        protected override void OnHide()
        {
        }

        protected override void OnClose()
        {
        }
    }
}
