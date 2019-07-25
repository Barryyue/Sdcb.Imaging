using System;
using System.IO;
using Xunit;

namespace Sdcb.Imaging.Test
{
    public class WatermarkToolTest
    {
        [Fact]
        public void Test1()
        {
            WatermarkTool.WatermarkText(File.OpenRead(@"D:\_\WatermarkDemo.png"), File.OpenWrite(@"D:\_\Demo2.png"), "ˮӡ�ڴ�", 
                font: "΢���ź�", 
                fontSize: 30, 
                colorARGB: 0x7f_FF_FF_FF);
        }

        [Fact]
        public void Test2()
        {
            var ms = WatermarkTool.WatermarkText(File.OpenRead(@"D:\_\WatermarkDemo.png"), "ˮӡ�ڴ�",
                font: "΢���ź�",
                fontSize: 30,
                colorARGB: 0x7f_FF_FF_FF);
            using (var file = File.OpenWrite(@"D:\_\Demo2.png"))
            {
                ms.CopyTo(file);
            }
        }
    }
}
