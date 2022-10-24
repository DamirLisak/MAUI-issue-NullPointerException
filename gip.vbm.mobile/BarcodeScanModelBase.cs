using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gip.vbm.mobile
{
    public class BarcodeScanModelBase : EntityBase
    {
        public List<object> _DecodedEntitiesList;
        /// <summary>
        /// This List contains Entities that have been decoded on server-side
        /// Material, Facility, FacilityCharge...
        /// </summary>
        public List<object> DecodedEntitiesList
        {
            get
            {
                return _DecodedEntitiesList;
            }
            set
            {
                SetProperty(ref _DecodedEntitiesList, value);
            }
        }

        private object _SelectedEntity;
        /// <summary>
        /// Selected object from DecodedEntitiesList
        /// </summary>
        public object SelectedEntity
        {
            get
            {
                return _SelectedEntity;
            }
            set
            {
                SetProperty(ref _SelectedEntity, value);
            }
        }

        public virtual void Clear()
        {
            SelectedEntity = null;
            DecodedEntitiesList = new List<object>();
        }

        public void Populate()
        {
            DecodedEntitiesList = new List<object>()
            {
                new ACClass() {ACIdentifier = "1", ACCaption = "Class1", ACUrlComponent = "Class1"},
                new Material() {MaterialNo = "1", MaterialName1 = "Mat1"},
                new Material() {MaterialNo = "2", MaterialName1 = "Mat2"},
                new Material() {MaterialNo = "3", MaterialName1 = "Mat3"},
                new Material() {MaterialNo = "4", MaterialName1 = "Mat4"},
                new Material() {MaterialNo = "5", MaterialName1 = "Mat5"},
                new Material() {MaterialNo = "6", MaterialName1 = "Mat6"},
                new Material() {MaterialNo = "7", MaterialName1 = "Mat7"},
                new Material() {MaterialNo = "8", MaterialName1 = "Mat8"},
                new Material() {MaterialNo = "9", MaterialName1 = "Mat9"},
                new ACClass() {ACIdentifier = "2", ACCaption = "Class2", ACUrlComponent = "Class2"},
                new Material() {MaterialNo = "1", MaterialName1 = "Mat1"},
                new Material() {MaterialNo = "2", MaterialName1 = "Mat2"},
                new Material() {MaterialNo = "3", MaterialName1 = "Mat3"},
                new Material() {MaterialNo = "4", MaterialName1 = "Mat4"},
                new Material() {MaterialNo = "5", MaterialName1 = "Mat5"},
                new Material() {MaterialNo = "6", MaterialName1 = "Mat6"},
                new Material() {MaterialNo = "7", MaterialName1 = "Mat7"},
                new Material() {MaterialNo = "8", MaterialName1 = "Mat8"},
                new Material() {MaterialNo = "9", MaterialName1 = "Mat9"}
            };
            SelectedEntity = DecodedEntitiesList.FirstOrDefault();
        }
    }

}
