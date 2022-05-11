using Google.Apis.Books.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBR.Core.Entities;
using static Google.Apis.Books.v1.Data.Volume;

namespace TBR.Infrastructure.GoogleBookAPI
{
    public static class VolumeExtensions
    {


        public static Book ConvertToBook(this Volume volume)
        {
            return new Book()
            {
                Title = volume.VolumeInfo.Title,
                Authors = volume.VolumeInfo.Authors,
                AcessBookURLInfo = volume.VolumeInfo.InfoLink,
                BookMediumPicture = volume.VolumeInfo.ImageLinks.Medium,
                PublishDate = volume.VolumeInfo.PublishedDate,
                ISBN = volume.VolumeInfo.IndustryIdentifiers.Select(isbn => isbn.Identifier),
                Description = volume.VolumeInfo.Description
            };
        }
    }
}
