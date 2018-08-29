﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Sorting.Models
{
    public class FilterViewModels
    {
        public FilterViewModels(List<Company> companies, int? company, string name)
        {
            companies.Insert(0, new Company { Name = "Все", Id = 0 });
            Companies = new SelectList(companies, "Id", "Name", company);
            SelectedCompany = company;
            SelectedName = name;
        }

        public SelectList Companies { get; private set; }
        public int? SelectedCompany { get; private set; }
        public string SelectedName { get; private set; }
    }
}