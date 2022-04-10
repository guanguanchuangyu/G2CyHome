// -----------------------------------------------------------------------
//  <copyright file="AutoMapperConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-07-04 0:24</last-date>
// -----------------------------------------------------------------------

using AutoMapper.Configuration;

using G2CyHome.Authorization.Entities;

using OSharp.AutoMapper;
using OSharp.Json;


namespace G2CyHome.Authorization.Dtos
{
    /// <summary>
    /// DTO对象映射类
    /// </summary>
    public class AutoMapperConfiguration : AutoMapperTupleBase
    {
        /// <summary>
        /// 创建对象映射
        /// </summary>
        /// <param name="mapper">映射配置表达</param>
        public override void CreateMap()
        {
            CreateMap<EntityRoleInputDto, EntityRole>()
                .ForMember(mr => mr.FilterGroupJson, opt => opt.MapFrom(dto => dto.FilterGroup.ToJsonString(false, false)));
        }
    }
}
