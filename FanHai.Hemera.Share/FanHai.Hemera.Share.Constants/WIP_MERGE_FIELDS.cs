﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FanHai.Hemera.Share.Constants
{
    public class WIP_MERGE_FIELDS:TableFields
    {
        public const string FIELD_TRANSACTION_KEY = "TRANSACTION_KEY";
        public const string FIELD_MAIN_LOT_KEY = "MAIN_LOT_KEY";
        public const string FIELD_CHILD_LOT_KEY = "CHILD_LOT_KEY";
        public const string FIELD_MERGE_QUANTITY = "MERGE_QUANTITY";
        public const string FIELD_STEP_KEY = "STEP_KEY";
        public const string FIELD_ROUTE_KEY = "ROUTE_KEY";
        public const string FIELD_ENTERPRISE_KEY = "ENTERPRISE_KEY";
        public const string FIELD_EDITOR = "EDITOR";
        public const string FIELD_EDIT_TIME = "EDIT_TIME";
        public const string FIELD_EDIT_TIMEZONE = "EDIT_TIMEZONE";
        public const string FIELD_CHILD_TRANSACTION_KEY = "CHILD_TRANSACTION_KEY";
        public const string DATABASE_TABLE_NAME = "WIP_MERGE";
        

        public override string TABLE_NAME
        {
            get
            {
                return DATABASE_TABLE_NAME;
            }
        }

        public override Dictionary<string, FieldProperties> FIELDS
        {
            get
            {
                return _fields;
            }
        }

        private static  Dictionary<string, FieldProperties> _fields = new Dictionary<string, FieldProperties>
                                                            { 
                                                            {FIELD_TRANSACTION_KEY,new FieldProperties()},
                                                            {FIELD_MAIN_LOT_KEY,new FieldProperties()}, 
                                                            {FIELD_CHILD_LOT_KEY,new FieldProperties()},                                                             
                                                            {FIELD_MERGE_QUANTITY ,new FieldProperties()},          
                                                            {FIELD_STEP_KEY ,new FieldProperties()},       
                                                            {FIELD_ROUTE_KEY,new FieldProperties()},
                                                            {FIELD_ENTERPRISE_KEY,new FieldProperties()},
                                                            {FIELD_EDITOR,new FieldProperties()},
                                                            {FIELD_EDIT_TIME,new FieldProperties(typeof(DateTime),true,DateTime.Now)},
                                                            {FIELD_EDIT_TIMEZONE,new FieldProperties()},
                                                            {FIELD_CHILD_TRANSACTION_KEY,new FieldProperties()},
                                                             
                                                            };

    }
}
