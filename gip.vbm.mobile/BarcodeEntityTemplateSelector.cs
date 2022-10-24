using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gip.vbm.mobile
{
    public class BarcodeEntityTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Unknown { get; set; }
        public DataTemplate Material { get; set; }
        public DataTemplate ACClass { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Material)
                return Material;
            if (item is ACClass)
                return ACClass;
            return Unknown;
        }
    }

}
