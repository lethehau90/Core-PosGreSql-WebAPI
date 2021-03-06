﻿using AutoMapper;
using PosGreSql.WebAPI.Models.Post;
using PostGreSql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PosGreSql.WebAPI.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
            });
        }
    }
}