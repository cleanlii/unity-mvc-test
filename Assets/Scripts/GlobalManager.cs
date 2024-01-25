using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using JetBrains.Annotations;

namespace ProjectPackage
{
    public class GlobalManager
    {
        /// <summary>
        /// 测试数据：字符串
        /// </summary>
        /// <typeparam name="string"></typeparam>
        /// <returns></returns>
        public static BindableProperty<string> testTitle = new BindableProperty<string>("Project 0");

        /// <summary>
        /// 测试数据：整形变量
        /// </summary>
        /// <typeparam name="int"></typeparam>
        /// <returns></returns>
        public static BindableProperty<int> testData = new BindableProperty<int>(0);

        /// <summary>
        /// 测试数据：布尔值
        /// </summary>
        /// <typeparam name="bool"></typeparam>
        /// <returns></returns>
        public static BindableProperty<bool> testBool = new BindableProperty<bool>(false);
    }
}
