using sidebarComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.Validations
{
    public class CategoryValidation
    {
        public static bool CheckIfCategoryIsUnchanged(RoundedPictureButtonRight category, RoundedPictureButtonRight genre)
        {
            return category.Text.Equals("Category") && genre.Text.Equals("Genre");
        }
    }
}
