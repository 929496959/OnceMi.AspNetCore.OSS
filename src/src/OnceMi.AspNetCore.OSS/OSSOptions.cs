using Minio;
using System;

namespace OnceMi.AspNetCore.OSS
{
    public enum OSSProvider
    {
        /// <summary>
        /// ��Ч
        /// </summary>
        Invalid = 0,

        /// <summary>
        /// Minio�Խ����󴢴�
        /// </summary>
        Minio = 1,

        /// <summary>
        /// ������OSS
        /// </summary>
        Aliyun = 2,

        /// <summary>
        /// ��Ѷ��OSS
        /// </summary>
        QCloud = 3,

        /// <summary>
        /// ��ţ�� OSS
        /// </summary>
        Qiniu = 4,

        /// <summary>
        /// ��Ϊ�� OBS
        /// </summary>
        HuaweiCloud = 5
    }

    public class OSSOptions
    {
        public OSSProvider Provider { get; set; }

        public string Endpoint { get; set; }

        public string AccessKey { get; set; }

        public string SecretKey { get; set; }

        private string _region = "us-east-1";

        public string Region
        {
            get
            {
                return _region;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _region = "us-east-1";
                }
                else
                {
                    _region = value;
                }
            }
        }

        public string SessionToken { get; set; }

        public bool IsEnableHttps { get; set; } = true;

        /// <summary>
        /// �Ƿ�����Redis������ʱURL
        /// </summary>
        public bool IsEnableCache { get; set; } = false;
    }
}