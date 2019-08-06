using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Pic_Integrate
{
    
    /// <summary>
    /// 参数列表
    /// </summary>
    [Serializable]
    public class Para
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Para()
        {
            TemplateFile = "Template File Lost";
            SourcePath = "Not Config";
            SealSize = new Size(512,480);
            SheetSize = new Size(512, 480);
            TemplateFileList = new List<string>();
            TemplateData = null;
            GlassInfos = new List<GlassInfo>();
            ImgSavePath = @"./Img/";
            GlassDirection = Direction.BottomRight;
            IsSaveSearchHistory = true;
        }

        /// <summary>
        /// 模板文件
        /// </summary>
        public string TemplateFile { get; set; }

        /// <summary>
        /// 图片保存目录
        /// </summary>
        public string ImgSavePath { get; set; }

        /// <summary>
        /// 源文件目录
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// GlassDirection
        /// </summary>
        public Direction GlassDirection { get; set; } 

        /// <summary>
        /// Seal Picture Size
        /// </summary>
        public Size SealSize { get; set; }

        /// <summary>
        /// Sheet Picture Size
        /// </summary>
        public Size SheetSize { get; set; }

        /// <summary>
        /// 模板文件list
        /// </summary>
        public List<string> TemplateFileList { get; set; } = new List<string>();

        /// <summary>
        /// 模板配置文件
        /// </summary>
        public DataTable TemplateData { get; set; }

        /// <summary>
        /// GlassInfos
        /// </summary>
        public List<GlassInfo> GlassInfos { get; set; } = new List<GlassInfo>();

        /// <summary>
        /// IsSaveSearchHistory 
        /// </summary>
        public bool IsSaveSearchHistory { get; set; } = true;
    }
    /// <summary>
    /// Glass信息
    /// </summary>
    [Serializable]
    public class GlassInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// DirName
        /// </summary>
        public string DirName { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// Equip00_ID
        /// </summary>
        public string Equip00_ID { get; set; }
        /// <summary>
        /// Equip01_ID
        /// </summary>
        public string Equip01_ID { get; set; }
        /// <summary>
        /// 监测点1 deviate
        /// </summary>
        public SheetShift Point1 { get; set; }
        /// <summary>
        /// 监测点2 deviate
        /// </summary>
        public SheetShift Point2 { get; set; }
        /// <summary>
        /// 监测点3 deviate
        /// </summary>
        public SheetShift Point3 { get; set; }
        /// <summary>
        /// 监测点4 deviate
        /// </summary>
        public SheetShift Point4 { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public GlassInfo()
        {
            Id = "";
            DirName = "";
            CreateTime = DateTime.Now.ToString("yyyyMMdd hh_ss");
            Equip00_ID = "";
            Equip01_ID = "";
            Point1 = new SheetShift(0,0);
            Point2 = new SheetShift(0, 0);
            Point3 = new SheetShift(0, 0);
            Point4 = new SheetShift(0, 0);
        }
    }
    /// <summary>
    /// 方向
    /// </summary>
    public enum Direction
    {
        TopLeft = 0,
        BottomLeft = 2,
        TopRigth = 4,
        BottomRight = 8
    }
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class SheetShift
    {
        public string X { get; set; }
        public string Y { get; set; }
        public SheetShift()
        {
            X = "";
            Y = "";
        }
        public SheetShift(int x,int y)
        {
            X = x.ToString();
            Y = y.ToString();
        }
        public SheetShift(string x, string y)
        {
            X = x;
            Y = y;
        }
    }
}
