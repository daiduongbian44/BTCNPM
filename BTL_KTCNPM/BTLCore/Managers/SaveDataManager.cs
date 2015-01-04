using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using BTLCore.Entities;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BTLCore.Managers
{
    public class SaveDataManager
    {
        [Serializable]
        class ItemManager
        {
            public ObservableCollection<ErrorEntity> ListErrors { get; set; }
            public ObservableCollection<TERelationshipEntity> ListTERelationships { get; set; }
            public ObservableCollection<TechniqueEntity> ListTechniques { get; set; }
        }

        public static void SaveData(String FileName)
        {
            ItemManager item = new ItemManager();
            item.ListErrors = ErrorManager.ListErrors;
            item.ListTechniques = TechniqueManager.ListTechniques;
            item.ListTERelationships = TERelationshipManager.ListTERelationship;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FileName,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, item);
            stream.Close();
        }

        public static void ReadData(String FileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FileName,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            ItemManager item = (ItemManager)formatter.Deserialize(stream);
            ErrorManager.ListErrors = item.ListErrors;
            TechniqueManager.ListTechniques = item.ListTechniques;
            TERelationshipManager.ListTERelationship = item.ListTERelationships;
            stream.Close();
        }
    }
}
