﻿using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class JobFieldsViewModel:BaseViewModel
    {
        // TODO #7.2 - Extract members common to SearchJobsViewModel
        // to BaseViewModel

        // The column to search, defaults to all
        public JobFieldType Column { get; set; }

        // All fields in the given column
        public IEnumerable<JobField> Fields { get; set; }

        
    }
}
