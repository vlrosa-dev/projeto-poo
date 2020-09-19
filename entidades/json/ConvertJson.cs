using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace projeto_poo.entidades
{
    public class ConvertJson
    {
        
        public T ConvertJsonForObject<T>(string jsonString){
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public string ConvertObjectForJson<T>(T obj){

            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString; 
            }
            catch (System.Exception)
            {
                
                throw;
            }

        }
    }
}