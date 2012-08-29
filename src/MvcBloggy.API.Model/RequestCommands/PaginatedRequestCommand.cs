﻿using MvcBloggy.API.Model.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.RequestCommands {

    public class PaginatedRequestCommand : RequestCommand {

        [Minimum(1)]
        public int Page { get; set; }

        [Minimum(1)]
        public int Take { get; set; }
    }
}