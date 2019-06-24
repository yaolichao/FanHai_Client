﻿#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion


namespace FanHai.Hemera.Share.Constants
{
    public class EDC_MAIN_FIELDS : TableFields
    {
        #region columns define
        public const string FIELD_EDC_KEY         = "EDC_KEY";
        public const string FIELD_EDC_NAME        = "EDC_NAME";
        public const string FIELD_DESCRIPTIONS    = "DESCRIPTIONS";
        public const string FIELD_COLLECTION_TYPE = "COLLECTION_TYPE";
        public const string FIELD_EDC_TABLE_NAME  = "EDC_TABLE_NAME";
        public const string FIELD_CREATE_TIME     = "CREATE_TIME";
        public const string FIELD_EDITOR          = "EDITOR";
        public const string FIELD_EDIT_TIME       = "EDIT_TIME";
        public const string FIELD_EDIT_TIMEZONE   = "EDIT_TIMEZONE";
        public const string FIELD_SITE_NUMBER     = "SITE_NUMBER"; 
        public const string FIELD_EDC_VERSION     = "EDC_VERSION"; 
        public const string FIELD_STATUS          = "STATUS"; 

        #endregion

        #region table name define
        public const string DATABASE_TABLE_NAME = "EDC_MAIN";       //TABLE NAME
        #endregion

        #region get TABLE_NAME
        /// <summary>
        /// override TABLE_NAME
        /// </summary>
        public override string TABLE_NAME
        {
            get
            {
                return DATABASE_TABLE_NAME;
            }
        }
        #endregion

        #region get FIELDS
        /// <summary>
        /// override fields
        /// </summary>
        public override Dictionary<string, FieldProperties> FIELDS
        {
            get
            {
                return _fields;
            }
        }
        #endregion

        #region define dictionary of containing column's fields
        //define _fields
        private static Dictionary<string, FieldProperties> _fields = new Dictionary<string, FieldProperties>
                                                              {
                                                                    {FIELD_EDC_KEY, new FieldProperties() },        
                                                                    {FIELD_EDC_NAME, new FieldProperties() },       
                                                                    {FIELD_DESCRIPTIONS, new FieldProperties() },   
                                                                    {FIELD_COLLECTION_TYPE, new FieldProperties() },
                                                                    {FIELD_EDC_TABLE_NAME, new FieldProperties() }, 
                                                                    {FIELD_CREATE_TIME, new FieldProperties(typeof(DateTime), true, DateTime.Now) },    
                                                                    {FIELD_EDITOR, new FieldProperties() },         
                                                                    {FIELD_EDIT_TIME, new FieldProperties(typeof(DateTime), true, DateTime.Now) },      
                                                                    {FIELD_EDIT_TIMEZONE, new FieldProperties() },  
                                                                    {FIELD_SITE_NUMBER, new FieldProperties() },    
                                                                    {FIELD_EDC_VERSION, new FieldProperties() },    
                                                                    {FIELD_STATUS, new FieldProperties() }         
                                                              };
        #endregion
    }
}
