// -----------------------------------------------------------------------
//  <copyright file="AutoMapperConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2021 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2021-03-01 11:10</last-date>
// -----------------------------------------------------------------------

using AutoMapper.Configuration;
using G2CyHome.Systems.Entities;
using OSharp.AutoMapper;
using OSharp.Dependency;
using OSharp.Mapping;
using System;
using System.Linq;


namespace G2CyHome.Systems.Dtos
{
    public class AutoMapperConfiguration : AutoMapperTupleBase
    {
        /// <summary>
        /// 创建对象映射
        /// </summary>
        public override void CreateMap()
        {
            CreateMap<Menu, MenuOutputDto>()
                .ForMember(dto => dto.Children, opt => opt.MapFrom(entity => entity.Children.Select(m => m.MapTo<MenuOutputDto>())));
        }
    }
}
