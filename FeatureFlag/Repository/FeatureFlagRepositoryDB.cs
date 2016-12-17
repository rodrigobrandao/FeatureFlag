using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureFlag.Repository
{
    public class FeatureFlagRepositoryDB: IFeatureFlagRepository
    {
        public IList<IFeature> GetFeatures()
        {
            IList<IFeature> features = new List<IFeature>();

            Infrastructure.DataBase dataBase = new Infrastructure.DataBase();
            DataTable dt = dataBase.ExecuteDataTable("SELECT * FROM [dbo].[TB_FEATURE_FLAG]");
            
            if(dt!=null && dt.Rows.Count > 0)
            {
                for(int i=0; i < dt.Rows.Count; i++)
                {
                    string name = dt.Rows[i]["Name"].ToString();
                    string state = dt.Rows[i]["State"].ToString();
                                        
                    DateTime startDate = DateTime.MinValue;
                    DateTime.TryParse(dt.Rows[i]["StartDate"].ToString(), out startDate);

                    features.Add(new Feature(name, (EnumState)Enum.Parse(typeof(EnumState), state), startDate));                    
                }
            }            

            return features;
        }
    }
}
