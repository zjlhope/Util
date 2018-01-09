﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Ui.Material.Enums;
using Util.Ui.Material.Forms.Configs;
using Util.Ui.Material.Forms.Renders;
using Util.Ui.Renders;
using Util.Ui.TagHelpers;

namespace Util.Ui.Material.Forms.TagHelpers {
    /// <summary>
    /// 文本框
    /// </summary>
    [HtmlTargetElement( "util-textbox" )]
    public class TextBoxTagHelper : FormControlTagHelperBase {
        /// <summary>
        /// 是否显示清除按钮
        /// </summary>
        public bool ShowClearButton { get; set; }
        /// <summary>
        /// 只读
        /// </summary>
        public bool Readonly { get; set; }
        /// <summary>
        /// 文本框类型
        /// </summary>
        public TextBoxType Type { get; set; }
        /// <summary>
        /// 电子邮件错误消息
        /// </summary>
        public string EmailMessage { get; set; }
        /// <summary>
        /// 最小长度
        /// </summary>
        public string MinLength { get; set; }
        /// <summary>
        /// 最小长度错误消息
        /// </summary>
        public string MinLengthMessage { get; set; }
        /// <summary>
        /// 最大长度
        /// </summary>
        public string MaxLength { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender( Context context ) {
            return new TextBoxRender( new TextBoxConfig( context ) );
        }
    }
}