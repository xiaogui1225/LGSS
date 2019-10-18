using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSGL
{
    public partial class Frm012_申请表 : Form
    {
        public Frm012_申请表()
        {
            InitializeComponent();
        }
        //首先要知道有谁要换宿舍，这些资料，用grivw控件来做查看两个表，一个换宿舍申请表，一个宿舍表， 用控件判断查哪一个表
        //同意就修改到还有位的宿舍，并删除申请换宿舍这条记录 
        //不同意，就不同意。
    }
}
