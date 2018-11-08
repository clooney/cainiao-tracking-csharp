using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 List all carriers
            // string urlStr = null;
            // string requestData=null;
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"carriers");

            // 2 detect a carriers by tracking number
            // string urlStr = null;
            // string requestData="{\"tracking_number\":\"LP00105238881631\"}";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"carriers/detect");

            // 3 create a tracking number
            string urlstr = null;
            string requestdata = "{\"tracking_number\": \"LP00105238881631\",\"carrier_code\":\"cainiao\",\"title\":\"4PX page\",\"customer_name\":\"trackingmore user\",\"customer_email\":\"service@trackingmore.com\",\"order_id\":\"#123\",\"order_create_time\":\"2018/09/08 16:51\",\"destination_code\":\"US\",\"tracking_ship_date\":\"20180908\",\"tracking_postal_code\":\"12201\",\"lang\":\"en\",\"logistics_channel\":\"API TEST\"}";
            string result = new Tracker().getOrderTracesByJson(requestdata, urlstr, "post");

            // 4 List all trackings
            // string urlStr = "?page=1&limit=100&created_at_min=&created_at_max=&update_time_min=&update_time_max=&order_created_time_min=&order_created_time_max=1541314361&numbers=LP00105238881631&orders=&lang=en";
            // string requestData = null;
            // string result = new Tracker().getOrderTracesByJson(requestData, urlStr, "get");

            // 5 Get tracking results of a single tracking.
            // string urlStr = "/cainiao/LP00105238881631/en";
            // string requestData = null;
            // string result = new Tracker().getOrderTracesByJson(requestData, urlStr, "codeNumberGet");

            // 6 create muti tracking number
            // string urlstr = null;
            // string requestdata = "[{\"tracking_number\": \"LP00105238881631\",\"carrier_code\":\"cainiao\",\"title\":\"4PX page\",\"customer_name\":\"trackingmore user\",\"customer_email\":\"service@trackingmore.com\",\"order_id\":\"#123\",\"order_create_time\":\"2018/09/08 16:51\",\"destination_code\":\"{destination_code}\",\"tracking_ship_date\":\"20180908\",\"tracking_postal_code\":\"12201\",\"lang\":\"en\",\"logistics_channel\":\"API TEST\"},{\"tracking_number\": \"LZ448865302CN\",\"carrier_code\":\"china-ems\",\"title\":\"4PX page\",\"customer_name\":\"trackingmore user\",\"customer_email\":\"service@trackingmore.com\",\"order_id\":\"#123\",\"order_create_time\":\"2018/09/08 16:51\",\"destination_code\":\"{destination_code}\",\"tracking_ship_date\":\"20180908\",\"tracking_postal_code\":\"12201\",\"lang\":\"en\",\"logistics_channel\":\"API TEST\"}]";
            // string result = new Tracker().getOrderTracesByJson(requestdata, urlstr, "batch");

            // 7 Update Tracking item
            // string urlStr = "/cainiao/LP00105238881631";
            // string requestData = "{\"title\": \"4PX page\",\"customer_name\":\"trackingmore user\",\"customer_email\":\"service@trackingmore.com\",\"order_id\":\"#123\",\"logistics_channel\":\"API TEST\",\"customer_phone\":\"+86 13142052920\",\"destination_code\":\"US\",\"status\":\"7\"}";
            // string result = new Tracker().getOrderTracesByJson(requestData, urlStr, "codeNumberPut");

            // 8 Delete a tracking item
            // string urlStr = "/cainiao/LP00105238881631";
            // string requestData = null;
            // string result = new Tracker().getOrderTracesByJson(requestData, urlStr, "codeNumberDel");

            // 9 Get realtime tracking results of a single tracking 
            // string urlstr = null;
            // string requestdata = "{\"tracking_number\": \"LP00105238881631\",\"carrier_code\":\"cainiao\",\"destination_code\":\"{destination_code}\",\"tracking_ship_date\": \"20180908\",\"tracking_postal_code\":\"12201\",\"specialNumberDestination\":\"UK\",\"order\":\"#123\",\"order_create_time\":\"2018/09/08 16:51\",\"lang\":\"en\"}";
            // string result = new Tracker().getOrderTracesByJson(requestdata, urlstr, "realtime");

            // 10 Modify courier code
            // string   urlStr =null;
            // string requestData="{\"tracking_number\": \"LP00105238881631\",\"carrier_code\":\"cainiao\",\"update_carrier_code\":\"china-ems\"}";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"update");

            // 11 Get user info
            // string   urlStr =null;
            // string requestData=null;
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"getuserinfo");

            // 12 Get status number
            // string   urlStr =null;
            // string requestData=null;
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"getstatusnumber");

            // 13 Set number not update
            // string   urlStr =null;
            // string requestData= "[{\"tracking_number\":\"LP00105238881631\",\"carrier_code\":\"cainiao\"},{\"tracking_number\":\"LZ448865302CN\",\"carrier_code\":\"china-ems\"}]";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"notupdate");

            // 14 Get remote iterm results
            // string   urlStr =null;
            // string requestData= "[{\"country\":\"CN\",\"postcode\":\"400422\"},{\"country\":\"CN\",\"postcode\":\"412000\"}]";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"remote");

            // 15 Get cost time iterm results
            // string   urlStr =null;
            // string requestData= "[{\"carrier_code\":\"cainiao\",\"destination\":\"US\",\"original\":\"CN\"},{\"carrier_code\":\"china-ems\",\"destination\":\"US\",\"original\":\"CN\"}]";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"costtime");

            // 16 Delete multiple tracking item
            // string   urlStr =null;
            // string requestData= "[{\"tracking_number\":\"LP00105238881631\",\"carrier_code\":\"cainiao\"},{\"tracking_number\":\"LZ448865302CN\",\"carrier_code\":\"china-ems\"}]";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"delete");

            // 17 Update multiple Tracking item
            // string   urlStr =null;
            // string requestData="[{\"tracking_number\":\"LP00105238881631\",\"carrier_code\":\"cainiao\",\"title\": \"4PX page\",\"customer_name\":\"trackingmore user\",\"customer_email\":\"service@trackingmore.com\",\"order_id\":\"#123\",\"logistics_channel\":\"API TEST\",\"destination_code\":\"US\",\"status\":\"7\"},{\"tracking_number\":\"LZ448865302CN\",\"carrier_code\":\"china-ems\",\"title\": \"4PX page\",\"customer_name\":\"trackingmore user\",\"customer_email\":\"service@trackingmore.com\",\"order_id\":\"#123\",\"logistics_channel\":\"API TEST\",\"destination_code\":\"US\",\"status\":\"7\"}]";
            // string result = new Tracker().getOrderTracesByJson(requestData,urlStr,"updatemore");


            //Console.WriteLine("result:" + result);
        }
    }
}
