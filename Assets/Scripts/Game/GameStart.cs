using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using SimpleJSON;

using QFramework;

namespace ProjectPackage
{
    public partial class GameStart : ViewController
    {

        void Start()
        {
            string gameConfDir = "Assets/Plugins/Luban/GenData";
            var tables = new cfg.Tables(file => JSON.Parse(File.ReadAllText($"{gameConfDir}/{file}.json")));

            GlobalManager.testTitle.Value = tables.TbReward.Get(1004).Name;
            GlobalManager.testData.Value = tables.TbReward.Get(1004).Count;
            GlobalManager.testBool.Value = tables.TbReward.Get(1004).Iscarry;

            ResKit.Init();
            UIKit.OpenPanel<UIGamePanel>();

        }

    }
}
