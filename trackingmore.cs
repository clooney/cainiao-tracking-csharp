using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;

namespace API
{
    public class Tracker
    {
        // the apikey you get from trackingmore
        private string ApiKey = "YOUR API KEY";
        

        public string getOrderTracesByJson(string requestData, string urlStr, string method)
        {
            string result = null;
             if (method.Equals("post")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings/post";
                 string RelUrl = ReqURL + urlStr;
                 result = sendPost(ReqURL, requestData,"POST");

             }else if (method.Equals("get")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings/get";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "GET");

             }else if (method.Equals("batch")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings/batch";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "POST");

             }else if (method.Equals("codeNumberGet")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "GET");

             }else if (method.Equals("codeNumberPut")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "PUT");

             }else if (method.Equals("codeNumberDel")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "DELETE");

             }else if (method.Equals("realtime")){

                 string ReqURL = "http://api.trackingmore.com/v2/trackings/realtime";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "POST");

             }else if (method.Equals("carriers")){

                 string ReqURL = "http://api.trackingmore.com/v2/carriers";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "GET");

             }else if (method.Equals("carriers/detect")){

                 string ReqURL = "http://api.trackingmore.com/v2/carriers/detect";
                 string RelUrl = ReqURL + urlStr;
                 //Console.WriteLine("RelUrl:" + RelUrl);
                 result = sendPost(RelUrl, requestData, "POST");

             }else if (method.Equals("update")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/update";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");

             }else if(method.Equals("getuserinfo")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/getuserinfo";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "GET");

             }else if(method.Equals("getstatusnumber")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/getstatusnumber";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "GET");

             }else if(method.Equals("notupdate")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/notupdate";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");

             }else if(method.Equals("remote")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/remote";
                string RelUrl = ReqURL + urlStr;
                Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");

             }else if(method.Equals("costtime")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/costtime";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");

             }else if(method.Equals("delete")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/delete";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");

             }else if(method.Equals("updatemore")){

                string ReqURL = "http://api.trackingmore.com/v2/trackings/updatemore";
                string RelUrl = ReqURL + urlStr;
                //Console.WriteLine("RelUrl:" + RelUrl);
                result = sendPost(RelUrl, requestData, "POST");

             }

            return result;
            
           
            
        }


        private string sendPost(string url, string requestData,string method)
        {
            string result = "";
            byte[] byteData = null;
            if (requestData !=null)
            {
                 byteData = Encoding.GetEncoding("UTF-8").GetBytes(requestData.ToString());
            }
          
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded";
                request.Timeout = 30 * 1000;
                request.Method = method;
                request.Headers["Trackingmore-Api-Key"] = ApiKey;
                
                if (byteData != null)
                {
                    Stream stream = request.GetRequestStream();
                    stream.Write(byteData, 0, byteData.Length);
                    stream.Flush();
                    stream.Close();
                }
                
                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream backStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(backStream, Encoding.GetEncoding("UTF-8"));
                result = sr.ReadToEnd();
                sr.Close();
                backStream.Close();
                response.Close();
                request.Abort();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}



