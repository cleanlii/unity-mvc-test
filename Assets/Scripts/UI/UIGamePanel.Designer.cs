using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace ProjectPackage
{
	// Generate Id:fa533506-96cc-4aa4-a44a-4c79b45ea13c
	public partial class UIGamePanel
	{
		public const string Name = "UIGamePanel";
		
		[SerializeField]
		public UnityEngine.UI.Text TestTitle;
		[SerializeField]
		public UnityEngine.UI.Text TestData;
		[SerializeField]
		public UnityEngine.UI.Text TestBool;
		
		private UIGamePanelData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			TestTitle = null;
			TestData = null;
			TestBool = null;
			
			mData = null;
		}
		
		public UIGamePanelData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIGamePanelData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIGamePanelData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
