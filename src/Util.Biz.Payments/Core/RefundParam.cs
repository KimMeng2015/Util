﻿
namespace Util.Biz.Payments.Core
{
    /// <summary>
    /// 退款参数
    /// </summary>
    public class RefundParam: PayParam
    {
        /// <summary>
        /// 退款原因
        /// </summary>
        public string RefundDesc { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        public decimal RefundFee { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string RefundNo { get; set; }
        /// <summary>
        /// 微信订单号 与商户订单号 必须二选一
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 证书绝对路径，如@"C:\apiclient_cert.p12"
        /// </summary>
        public string Cert { get; set; }
        /// <summary>
        /// 证书密码
        /// </summary>
        public string Password { get; set; }
    }
}
