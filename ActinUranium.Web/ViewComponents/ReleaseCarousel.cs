﻿using Microsoft.AspNetCore.Mvc;
using ActinUranium.Web.Models;
using ActinUranium.Web.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ActinUranium.Web.ViewComponents
{
    public class ReleaseCarousel : ViewComponent
    {
        private readonly CreationStore _creationStore;
        private readonly HeadlineStore _headlineStore;

        public ReleaseCarousel(CreationStore creationStore, HeadlineStore headlineStore)
        {
            _creationStore = creationStore;
            _headlineStore = headlineStore;
        }

        public async Task<IViewComponentResult> InvokeAsync(int releaseCount)
        {
            // Take twice the required release count to ensure the chronological release order.
            IReadOnlyCollection<IRelease> creations = await _creationStore.GetCreationsAsync(releaseCount);
            IReadOnlyCollection<IRelease> headlines = await _headlineStore.GetRepresentativeHeadlinesAsync(releaseCount);

            var model = creations.Concat(headlines)
                .OrderByDescending(r => r.ReleaseDate)
                .Take(releaseCount)
                .ToList();
            
            return View(model);
        }
    }
}
