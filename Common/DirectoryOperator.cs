// ----------------------------------------------------------------------------
// The MIT License
// Longshilin Library https://github.com/longshilin/longshilin.common
// Copyright (c) 2019-2020 Longshilin <583297550@qq.com>
// ----------------------------------------------------------------------------


// ReSharper disable ClassNeverInstantiated.Global

using System.IO;

namespace Longshilin.Common
{
    public class DirectoryOperator
    {
        /// 创建指定目录
        public static void CreateDir(string dirPath)
        {
            var dirInfo = new DirectoryInfo(dirPath);
            dirInfo.Create();

            if (!dirInfo.Exists)
            {
                return;
            }
        }

        /// 删除指定目录下所有内容
        public static void DeleteDir(string dirPath, bool isDeleteDir = true)
        {
            var dirInfo = new DirectoryInfo(dirPath);

            foreach (var file in dirInfo.GetFiles())
            {
                file.Delete();
            }

            foreach (var dir in dirInfo.GetDirectories())
            {
                dir.Delete(true);
            }

            if (isDeleteDir)
            {
                dirInfo.Delete();
            }
        }
    }
}