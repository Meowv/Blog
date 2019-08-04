﻿using MeowvBlog.Services.Dto.Signature;
using Plus;
using System.Threading.Tasks;

namespace MeowvBlog.Services.Signature
{
    public interface ISignatureLogService
    {
        /// <summary>
        /// 新增标签日志
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ActionOutput<string>> InsertSignatureLog(SignatureDto dto);

        /// <summary>
        /// 获取最近生成的签名数据
        /// </summary>
        /// <returns></returns>
        Task<ActionOutput<SignatureDto>> GetRecentlySignatureLog();
    }
}