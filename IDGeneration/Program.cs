using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateStoreKeyVal(); //wil call only once to create initial values for all stores

            string storeKey = GetStoreKey("Sydney General Super Shop");
            GenerateCode(storeKey); //will call for particular store for each day during promotion time

        }

        public static void GenerateStoreKeyVal()
        {
            //this method will generate key-value pair to identify particular store 
            Dictionary<string, string> StoreInfo = new Dictionary<string, string>();
            //Store value will be hex value and will require 2 characters to identify all 200 stores.
            //ensure to make it 2 characters
            //Sample value would be {C8, Sydney General Super Shop}

            int maxStoreCnt = 200;
            for(int storeCnt=0; storeCnt<maxStoreCnt; storeCnt++)
            { 
                SaveStoreInfo();
            }

        }

        public static string GetStoreKey(string StoreName)
        {
            //Database / XML query to retrieve store key

           
            return "C8"; //will return store info
        }

        public static void SaveStoreInfo()
        {
            //This method would be save data into the database / XML.
        }

        public static void GenerateCode(string StoreKey)
        {
            //This method will generate customer ID for each store starts from 0 - 100000 per day and 
            //also add the information of day-month of promotion
            //and will also incorporate store keys to identify store
                      
            int maxCustCnt = 10000;
         

            for(var custCnt=0; custCnt < maxCustCnt; custCnt++)
            {

                string custId = string.Empty;
                custId = custCnt.ToString("X");  // will give hexano for customer; ensure to make it 4 characters
               
                string dateOfToday = Convert.ToInt32(DateTime.Now.ToString("ddMM")).ToString("X"); //will return Day-Month in HEX with 3 characters

                //Customer Code definition would be
                //4 character customer no in hex
                //2 character store key
                //2 character for date representation
                //1 character for month representation

                string custCode;

                custCode = custId + dateOfToday + StoreKey;
                string custUniqueKey=GenerateRandomNo(); //this will be printed on their dockets

                SaveCustKeyInfo(custUniqueKey, custCode);

            }

        }

        public static string GenerateRandomNo()
        {
            //this method will generate unique key for each customer for each store per day. So each day max unique no would be for all stored 200*10000
            //key can be generate from any random no 
            return "AB0987P"; //sample outcome
        }

        public static void SaveCustKeyInfo(string custUniqueKey,string custCode)
        {
            //Will save customer code and corresponding key into the databse.
            //custUniqueKey and custCode field should indicate primary key into the table in database.


        }
    }
}
