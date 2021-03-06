﻿using ActinUranium.Web.Models;
using ActinUranium.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActinUranium.Web.ViewComponents
{
    public class RelatedHeadlineSection : ViewComponent
    {
        private readonly HeadlineStore _store;

        public RelatedHeadlineSection(HeadlineStore store)
        {
            _store = store;
        }

        public async Task<IViewComponentResult> InvokeAsync(Headline reference, int count)
        {
            IReadOnlyCollection<Headline> model = await _store.GetRepresentativeHeadlinesAsync(reference, count);
            return View(model);
        }
    }
}
