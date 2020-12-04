// ----------------------------------------------------------------------------
// The MIT License
// Simple Entity Component System framework https://github.com/longshilin/longshilin.common
// Copyright (c) 2019-2020 Longshilin <583297550@qq.com>
// ----------------------------------------------------------------------------


// ReSharper disable ClassNeverInstantiated.Global

using System.IO;

namespace Longshilin.Common
{
    public class DirectoryOperator
    {
        ///
        public static void DeleteAll(string dirPath)
        {
            var di = new DirectoryInfo(dirPath);

            foreach (var file in di.GetFiles())
            {
                file.Delete();
            }

            foreach (var dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}