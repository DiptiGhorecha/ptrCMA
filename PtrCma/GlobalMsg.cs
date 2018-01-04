using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PtrCma
{
    class GlobalMsg
    {
        //MDI Form MessageBox
        public static string resolutionMsg= "This Application Required Minimum Resolution 1280 x 768";

    // Party Form
        //Message Box
        public static string insertMsg = "Data inserted Successfully";
        public static string updateMsg = "Record Updated Successfully";
        public static string deleteMsg = "Record Successfully Deleted ";
        public static string selectMsg = "Please Create or Select Data First";
        public static string duplicateMsg = "Duplicate code is not allowed.";
        public static string deleteDataMsg="Data Already Exist You Can't Delete Record";
        public static string backMsg = "Backup Copied Successfully";
        public static string titleMsg = "Perfect Tax Reporter - CMA 1.0";

        //Dialog Message Box
        public static string updateMsgDialog = "Are you sure you want to update ?";
        public static string cancelMsgDialog = "Are You Sure Want to Cancel ?";
        public static string deleteMsgDialog = "Are you sure want to delete this Record ?";
        public static string exitMsgDialog = "Are You sure you want to Exit ?";

        //Validation
        public static string codeMsg = "Code Number Field cannot be Blank";
        public static string nameMsg = "Name Field cannot be Blank";
        public static string desMsg = "Description Field cannot be Blank";
        public static string saveMsg = "First save your changes";
        public static string bnkNameMsg = "Bank Name Field cannot be Blank";
    }
}
