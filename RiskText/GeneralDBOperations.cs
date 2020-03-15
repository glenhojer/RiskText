using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Data;
using Flow;
using IO;
using General;
using System.Net;
using System.Net.Sockets;
using System.Data.Common;

namespace General
{
    public static class DBOperation
    {
        #region initiation
        public static void CheckProgramTables() //Denne skal kunne blive mindre!!!
        {
            using (SqlConnection connection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Close();
                        String CS = Interaction.InputBox("The connection string does not work please write a new one?", "ConnectionString", riskEngineIO.Properties.Settings.Default.conenctionString, -1, -1);
                        if (CS == "")
                        {
                            MessageBox.Show("You did not write anything, the program therefore closes");
                            Application.Exit();
                        }
                        else
                        {
                            using (SqlConnection connection2 = new SqlConnection(CS))
                            {
                                try
                                {
                                    connection2.Open();
                                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                                    var connectionStringSection = (ConnectionStringsSection)config.GetSection("connectionString");
                                    connectionStringSection.ConnectionStrings["connectionString"].ConnectionString = CS;
                                    config.Save();
                                    ConfigurationManager.RefreshSection("connectionStrings");
                                    MessageBox.Show(string.Format("ConnectionString changed to \n {0}", riskEngineIO.Properties.Settings.Default.conenctionString));

                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("It still does work, program will shut down!");
                                    Application.Exit();
                                }
                            }
                        }
                        CS = null;
                    }
                }
            }
            var dt = new DataTable();
            try
            {
                bool schemaFoundationAM = false;
                bool schemaFoundationFM = false;
                bool schemaFoundation = false;
                bool schemaRiskEngine = false;
                bool schemaGuideLinesAM = false;
                bool schemaGuideLinesFM = false;
                bool schemaGuideLines = false;

                using (SqlConnection sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
                {
                    using (var sqlDataAdapter = new SqlDataAdapter(string.Format("SELECT S.name FROM sys.schemas S"), sqlConnection))
                    {
                        sqlDataAdapter.Fill(dt);
                        sqlConnection.Open();
                        //return dt;
                        foreach (DataRow r in dt.Rows)
                        {
                            foreach (string item in r.ItemArray)
                            {
                                if (item.ToString() == "FoundationAM")
                                {
                                    schemaFoundationAM = true;
                                }
                                else if (item.ToString() == "FoundationFM")
                                {
                                    schemaFoundationFM = true;
                                }
                                else if (item.ToString() == "Foundation")
                                {
                                    schemaFoundation = true;
                                }
                                else if (item.ToString() == "riskEngine")
                                {
                                    schemaRiskEngine = true;
                                }
                                else if (item.ToString() == "GuidelineAM")
                                {
                                    schemaGuideLinesAM = true;
                                }
                                else if (item.ToString() == "GuidelineFM")
                                {
                                    schemaGuideLinesFM = true;
                                }
                                else if (item.ToString() == "Guideline")
                                {
                                    schemaGuideLines = true;
                                }
                            }
                        }
                        dt = null;
                    }

                }
                if (schemaFoundationAM == false || schemaFoundationFM == false || schemaRiskEngine == false || schemaGuideLinesAM == false || schemaGuideLinesFM == false)
                {
                    DialogResult dialogResult = MessageBox.Show("You are missing schemas on database needed for gRisk to run properly, do you wish to create these", "Schema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //Foundation
                        if (!schemaFoundationFM)
                        {
                            string sqlSchema = "CREATE SCHEMA [FoundationFM]"; // AUTHORIZATION FM";
                            SQLNonQuery(sqlSchema);
                        }
                        if (!schemaFoundationAM)
                        {
                            string sqlSchema = "CREATE SCHEMA [FoundationAM]"; // AUTHORIZATION AM";
                            SQLNonQuery(sqlSchema);
                        }
                        if (!schemaFoundation)
                        {
                            string sqlSchema = "CREATE SCHEMA [Foundation]"; // AUTHORIZATION AM";
                            SQLNonQuery(sqlSchema);
                        }
                        //Guideline
                        if (!schemaGuideLinesFM)
                        {
                            string sqlSchema = "CREATE SCHEMA [GuidelineFM]"; // AUTHORIZATION FM";
                            SQLNonQuery(sqlSchema);
                        }
                        if (!schemaGuideLinesAM)
                        {
                            string sqlSchema = "CREATE SCHEMA [GuidelineAM]";
                            SQLNonQuery(sqlSchema);
                        }
                        if (!schemaGuideLines)
                        {
                            string sqlSchema = "CREATE SCHEMA [Guideline]";
                            SQLNonQuery(sqlSchema);
                            //"CREATE SCHEMA guidelineAM AUTHORIZATION AM" +
                            //"    GRANT SELECT ON SCHEMA::Sprockets TO Mandar" +
                            //"    DENY SELECT ON SCHEMA::Sprockets TO Prasanna";
                        }
                        //riskEngine
                        if (!schemaRiskEngine)
                        {
                            string sqlSchema =
                                "CREATE SCHEMA [riskEngine]" +
                                     " CREATE TABLE [Connector]" +
                                        "(" +
                                        " [ConnectorIK][int] IDENTITY(1, 1) NOT NULL," +
                                        " [Connector] [nvarchar] (50) NOT NULL," +
                                        " [DataType] [nvarchar] (50) NOT NULL," +
                                        " [Schema] [nvarchar] (50) NOT NULL," +
                                        " [Schema2] [nvarchar] (10) NULL," +
                                        " [Table] [nvarchar] (50) NOT NULL," +
                                        " [SQLConnectionString] [nvarchar] (500) NULL," +
                                        " [SQLStatement] [text] NULL," +
                                        " [SQLWhere] [text] NULL," +
                                        " [ExternalDate] [nvarchar] (50) NULL," +
                                        " [InternalDate] [nvarchar] (50) NULL," +
                                        " [DateOffset] [int] NULL," +
                                        " [ImportOption] [nvarchar] (50) NULL," +
                                        " [SQLNoValidation] [bit] NULL," +
                                        " [Folder] [nvarchar] (500) NULL," +
                                        " [File] [nvarchar] (500) NULL," +
                                        " [FileType] [nvarchar] (50) NULL," +
                                        " [Archive] [bit] NULL," +
                                        " [ArchiveFolder] [nvarchar] (500) NULL," +
                                        " [CSVHeader] [int] NULL," +
                                        " [CSVSeperator] [nvarchar] (50) NULL," +
                                        " [CSVTextQualifier] [nvarchar] (50) NULL," +
                                        " [ExcelHeader] [int] NULL," +
                                        " [ExcelSheet] [nvarchar] (50) NULL," +
                                        " [AdvancedParser] [nvarchar] (50) NULL," +
                                        " [Transform] [nvarchar] (50) NULL," +
                                        " [LastImportDate] [datetime] NULL," +
                                        " [CreatedBy] [nvarchar] (50) NULL," +
                                        " [Created] [datetime] NULL" +
                                        ")" +
                                    "CREATE TABLE [ConnectorFields]" +
                                        "(" +
                                        " [FieldIK][int] IDENTITY(1,1) NOT NULL," +
                                        " [ConnectorIK] [int] NOT NULL," +
                                        " [FieldOrder] [int] NOT NULL," +
                                        " [FieldName] [nvarchar] (50) NOT NULL," +
                                        " [FieldType] [nvarchar] (50) NOT NULL," +
                                        " [FieldLength] [int] NULL," +
                                        " [FieldDecimals] [int] NULL," +
                                        " [FieldTranslation] [nvarchar] (500) NULL," +
                                        " [FieldParse] [nvarchar] (100) NULL," +
                                        " [TableField] [nvarchar] (50) NOT NULL," +
                                        " [FieldTransform] [nvarchar] (50) NULL," +
                                        " [Description] [varchar] (500) NULL" +
                                        ")" +
                                    " CREATE TABLE [FieldTranslator]" +
                                        "(" +
                                        " [TranslatorIK] [INT] IDENTITY(1, 1) NOT NULL," +
                                        " [TranslatorID] [nvarchar] (50) NOT NULL," +
                                        " [DataType] [nvarchar] (50) NOT NULL," +
                                        " [ErrorHandling] [nvarchar] (50) NOT NULL," +
                                        " [Created] [datetime] NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [FieldTranslatorSub]" +
                                        "(" +
                                        " [IK] [INT] IDENTITY(1, 1) NOT NULL," +
                                        " [TranslatorIK] [INT] NOT NULL," +
                                        " [TranslateFrom] [nvarchar] (50) NOT NULL," +
                                        " [TranslateTo] [nvarchar] (50) NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [FieldParser]" +
                                        "(" +
                                        " [ParserIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [Parser] [nvarchar] (50) NOT NULL," +
                                        " [DataType] [nvarchar] (50) NOT NULL," +
                                        " [From] [nvarchar] (500) NULL," +
                                        " [DateInputType] [nvarchar] (50) NULL," +
                                        " [DateInputCountry] [nvarchar] (50) NULL," +
                                        " [DateOutputFormat] [nvarchar] (50) NULL," +
                                        " [TextGeneralCase] [nvarchar] (50) NULL," +
                                        " [TextReplaceFind] [nvarchar] (50) NULL," +
                                        " [TextReplaceReplace] [nvarchar] (50) NULL," +
                                        " [TextAddBeginning] [nvarchar] (50) NULL," +
                                        " [TextAddEnd] [nvarchar] (50) NULL," +
                                        " [DecRound] [int] NULL," +
                                        " [DecDecimal] [nvarchar] (5) NULL," +
                                        " [DecThousand] [nvarchar] (5) NULL," +
                                        " [RegexExpression] [nvarchar] (200) NULL," +
                                        " [RegexGroup] [nvarchar] (100) NULL," +
                                        " [CreatedBy] [nvarchar] (100) NOT NULL," +
                                        " [Created] [datetime] NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [ExternalFields]" +
                                        "(" +
                                        " [ExternalFieldsIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [ConnectorIK] [int] NOT NULL," +
                                        " [FieldTypeRank] [int] NOT NULL," +
                                        " [FieldName] [nvarchar] (50) NOT NULL," +
                                        " [FieldType] [nvarchar] (50) NOT NULL," +
                                        " [FieldLength] [int] NULL," +
                                        " [FieldDecimals] [int] NULL" +
                                        ")" +
                                    " CREATE TABLE [ConnectorImport]" +
                                        "(" +
                                        " [ImportIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [Import] [nvarchar] (50) NOT NULL," +
                                        " [ConnectorIK] [int] NOT NULL," +
                                        " [JobImportIK] [int] NOT NULL," +
                                        " [FilePath] [nvarchar] (500) NULL," +
                                        " [LogFile] [text] NULL," +
                                        " [CreatedBy] [nvarchar] (50) NOT NULL," +
                                        " [Created] [datetime] NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [Job]" +
                                        "(" +
                                        " [JobIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [JobName] [nvarchar] (50) NOT NULL," +
                                        " [JobType] [nvarchar] (50) NOT NULL," +
                                        " [JobFrequency] [nvarchar] (50) NOT NULL," +
                                        " [JobStartAfter] [nvarchar] (50) NULL," +
                                        " [Connector] [nvarchar] (50) NULL," +
                                        " [ConnectorIK] [int] NULL," +
                                        " [JobImportIK] [int] NULL," +
                                        " [ConnectorImportOption] [nvarchar] (50) NULL," +
                                        " [ConnectorImportOnlyPreviouslyImported] [bit] NULL," +
                                        " [Created] [datetime] NOT NULL," +
                                        " [CreatedBy] [nvarchar] (50) NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [JobImport]" +
                                        "(" +
                                        " [JobImportIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [JobImport] [nvarchar] (50) NOT NULL," +
                                        " [JobIK] [int] NOT NULL," +
                                        " [LogFile] [text] NULL," +
                                        " [Created] [datetime] NOT NULL," +
                                        " [CreatedBy] [nvarchar] (50) NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [Queue]" +
                                        "(" +
                                        " [ElementIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [ElementID] [nvarchar] (50) NOT NULL," +
                                        " [Executer] [nvarchar] (50) NOT NULL," +
                                        " [JobIK] [int] NOT NULL," +
                                        " [LastRun] [datetime] NOT NULL," +
                                        " [Created] [datetime] NOT NULL" +
                                        ")" +
                                    " CREATE TABLE [Instance]" +
                                        "(" +
                                        " [InstanceIK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [UserSystem] [nvarchar] (50) NOT NULL," +
                                        " [User] [nvarchar] (50) NOT NULL," +
                                        " [ElementIK] [int] NULL," +
                                        " [Action] [nvarchar] (20) NOT NULL," +
                                        " [CheckIn] [datetime] NULL," +
                                        " [Created] [datetime] NULL" +
                                        ")" +
                                    " CREATE TABLE [Random]" +
                                        "(" +
                                        " [IK] [int] IDENTITY(1, 1) NOT NULL," +
                                        " [BackgroundCount] [int] NOT NULL" +
                                        ")" +
                                   " CREATE TABLE [Country]" +
                                        "(" +
                                        "[IK] [int] IDENTITY(1,1) NOT NULL," +
                                        "[Country] [nvarchar] (50) NOT NULL," +
                                        "[Abbreviation] [nvarchar] (50) NOT NULL" +
                                        ")";

                            SQLNonQuery(sqlSchema);
                            sqlSchema = "INSERT INTO [riskEngine].[ConnectorImport] ([Import], [JobImportIK], [ConnectorIK], [Created], [CreatedBy])" +
                                                                $" VALUES('Preview',0 , 0, @GeneralDate, 'Program')";
                            SQLNonQuery(sqlSchema, DateTime.Now);
                            sqlSchema = "INSERT INTO [riskEngine].[Random] ([BackgroundCount])" +
                                    $" VALUES(0)";
                            SQLNonQuery(sqlSchema);

                            SQLNonQuery(sqlSchema);
                            sqlSchema = "INSERT INTO [riskEngine].[JobImport] ([JobImport], [JobIK], [Created], [CreatedBy])" +
                                                                $" VALUES('Preview', 0, @GeneralDate, 'Program')";
                            SQLNonQuery(sqlSchema, DateTime.Now);

                            sqlSchema = "INSERT INTO [riskEngine].[Country]" +
                                            " ([Country],[Abbreviation])" +
                                                " VALUES" +
                                                " ('Danish (Denmark)','da-DK')," +
                                                " ('English (United Kingdom)','en-GB')," +
                                                " ('English (United States)','en-US')," +
                                                " ('Afrikaans (South Africa)','af-ZA')," +
                                                " ('Albanian (Albania)','sq-AL')," +
                                                " ('Alsatian (France)','gsw-FR')," +
                                                " ('Amharic (Ethiopia)','am-ET')," +
                                                " ('Arabic (Algeria)','ar-DZ')," +
                                                " ('Arabic (Bahrain)','ar-BH')," +
                                                " ('Arabic (Egypt)','ar-EG')," +
                                                " ('Arabic (Iraq)','ar-IQ')," +
                                                " ('Arabic (Jordan)','ar-JO')," +
                                                " ('Arabic (Kuwait)','ar-KW')," +
                                                " ('Arabic (Lebanon)','ar-LB')," +
                                                " ('Arabic (Libya)','ar-LY')," +
                                                " ('Arabic (Morocco)','ar-MA')," +
                                                " ('Arabic (Oman)','ar-OM')," +
                                                " ('Arabic (Qatar)','ar-QA')," +
                                                " ('Arabic (Saudi Arabia)','ar-SA')," +
                                                " ('Arabic (Syria)','ar-SY')," +
                                                " ('Arabic (Tunisia)','ar-TN')," +
                                                " ('Arabic (U.A.E.)','ar-AE')," +
                                                " ('Arabic (Yemen)','ar-YE')," +
                                                " ('Armenian (Armenia)','hy-AM')," +
                                                " ('Assamese (India)','as-IN')," +
                                                " ('Azerbaijani (Cyrillic, Azerbaijan)','az-Cyrl-AZ')," +
                                                " ('Azerbaijani (Latin, Azerbaijan)','az-Latn-AZ')," +
                                                " ('Bangla (Bangladesh)','bn-BD')," +
                                                " ('Bangla (India)','bn-IN')," +
                                                " ('Bashkir (Russia)','ba-RU')," +
                                                " ('Basque (Basque)','eu-ES')," +
                                                " ('Belarusian (Belarus)','be-BY')," +
                                                " ('Bosnian (Cyrillic, Bosnia and Herzegovina)','bs-Cyrl-BA')," +
                                                " ('Bosnian (Latin, Bosnia and Herzegovina)','bs-Latn-BA')," +
                                                " ('Breton (France)','br-FR')," +
                                                " ('Bulgarian (Bulgaria)','bg-BG')," +
                                                " ('Burmese (Myanmar)','my-MM')," +
                                                " ('Catalan (Catalan)','ca-ES')," +
                                                " ('Central Atlas Tamazight (Latin, Algeria)','tzm-Latn-DZ')," +
                                                " ('Central Atlas Tamazight (Tifinagh, Morocco)','tzm-Tfng-MA')," +
                                                " ('Central Kurdish (Iraq)','ku-Arab-IQ')," +
                                                " ('Cherokee (Cherokee)','chr-Cher-US')," +
                                                " ('Chinese (Simplified, China)','zh-CN')," +
                                                " ('Chinese (Simplified, Singapore)','zh-SG')," +
                                                " ('Chinese (Traditional, Hong Kong SAR)','zh-HK')," +
                                                " ('Chinese (Traditional, Macao SAR)','zh-MO')," +
                                                " ('Chinese (Traditional, Taiwan)','zh-TW')," +
                                                " ('Corsican (France)','co-FR')," +
                                                " ('Croatian (Croatia)','hr-HR')," +
                                                " ('Croatian (Latin, Bosnia and Herzegovina)','hr-BA')," +
                                                " ('Czech (Czech Republic)','cs-CZ')," +
                                                " ('Dari (Afghanistan)','prs-AF')," +
                                                " ('Divehi (Maldives)','dv-MV')," +
                                                " ('Dutch (Belgium)','nl-BE')," +
                                                " ('Dutch (Netherlands)','nl-NL')," +
                                                " ('English (Australia)','en-AU')," +
                                                " ('English (Belize)','en-BZ')," +
                                                " ('English (Canada)','en-CA')," +
                                                " ('English (Caribbean)','en-029')," +
                                                " ('English (Hong Kong)','en-HK')," +
                                                " ('English (India)','en-IN')," +
                                                " ('English (Ireland)','en-IE')," +
                                                " ('English (Jamaica)','en-JM')," +
                                                " ('English (Malaysia)','en-MY')," +
                                                " ('English (New Zealand)','en-NZ')," +
                                                " ('English (Philippines)','en-PH')," +
                                                " ('English (Singapore)','en-SG')," +
                                                " ('English (South Africa)','en-ZA')," +
                                                " ('English (Trinidad and Tobago)','en-TT')," +
                                                " ('English (Zimbabwe)','en-ZW')," +
                                                " ('Estonian (Estonia)','et-EE')," +
                                                " ('Faroese (Faroe Islands)','fo-FO')," +
                                                " ('Filipino (Philippines)','fil-PH')," +
                                                " ('Finnish (Finland)','fi-FI')," +
                                                " ('French (Belgium)','fr-BE')," +
                                                " ('French (Cameroon)','fr-CM')," +
                                                " ('French (Canada)','fr-CA')," +
                                                " ('French (Congo [DRC])','fr-CD')," +
                                                " ('French (France)','fr-FR')," +
                                                " ('French (Haiti)','fr-HT')," +
                                                " ('French (Ivory Coast)','fr-CI')," +
                                                " ('French (Luxembourg)','fr-LU')," +
                                                " ('French (Mali)','fr-ML')," +
                                                " ('French (Monaco)','fr-MC')," +
                                                " ('French (Morocco)','fr-MA')," +
                                                " ('French (Réunion)','fr-RE')," +
                                                " ('French (Senegal)','fr-SN')," +
                                                " ('French (Switzerland)','fr-CH')," +
                                                " ('Frisian (Netherlands)','fy-NL')," +
                                                " ('Fulah (Latin, Senegal)','ff-Latn-SN')," +
                                                " ('Galician (Galician)','gl-ES')," +
                                                " ('Georgian (Georgia)','ka-GE')," +
                                                " ('German (Austria)','de-AT')," +
                                                " ('German (Germany)','de-DE')," +
                                                " ('German (Liechtenstein)','de-LI')," +
                                                " ('German (Luxembourg)','de-LU')," +
                                                " ('German (Switzerland)','de-CH')," +
                                                " ('Greek (Greece)','el-GR')," +
                                                " ('Greenlandic (Greenland)','kl-GL')," +
                                                " ('Guarani (Paraguay)','gn-PY')," +
                                                " ('Gujarati (India)','gu-IN')," +
                                                " ('Hausa (Latin, Nigeria)','ha-Latn-NG')," +
                                                " ('Hawaiian (United States)','haw-US')," +
                                                " ('Hebrew (Israel)','he-IL')," +
                                                " ('Hindi (India)','hi-IN')," +
                                                " ('Hungarian (Hungary)','hu-HU')," +
                                                " ('Icelandic (Iceland)','is-IS')," +
                                                " ('Igbo (Nigeria)','ig-NG')," +
                                                " ('Indonesian (Indonesia)','id-ID')," +
                                                " ('Inuktitut (Latin, Canada)','iu-Latn-CA')," +
                                                " ('Inuktitut (Syllabics, Canada)','iu-Cans-CA')," +
                                                " ('Irish (Ireland)','ga-IE')," +
                                                " ('isiXhosa (South Africa)','xh-ZA')," +
                                                " ('isiZulu (South Africa)','zu-ZA')," +
                                                " ('Italian (Italy)','it-IT')," +
                                                " ('Italian (Switzerland)','it-CH')," +
                                                " ('Japanese (Japan)','ja-JP')," +
                                                " ('Javanese (Indonesia)','jv-Latn-ID')," +
                                                " ('Kannada (India)','kn-IN')," +
                                                " ('Kazakh (Kazakhstan)','kk-KZ')," +
                                                " ('Khmer (Cambodia)','km-KH')," +
                                                " ('Kiche (Guatemala)','qut-GT')," +
                                                " ('Kinyarwanda (Rwanda)','rw-RW')," +
                                                " ('Kiswahili (Kenya)','sw-KE')," +
                                                " ('Konkani (India)','kok-IN')," +
                                                " ('Korean (Korea)','ko-KR')," +
                                                " ('Kyrgyz (Kyrgyzstan)','ky-KG')," +
                                                " ('Lao (Lao PDR)','lo-LA')," +
                                                " ('Latvian (Latvia)','lv-LV')," +
                                                " ('Lithuanian (Lithuania)','lt-LT')," +
                                                " ('Lower Sorbian (Germany)','dsb-DE')," +
                                                " ('Luxembourgish (Luxembourg)','lb-LU')," +
                                                " ('Macedonian (Former Yugoslav Republic of Macedonia)','mk-MK')," +
                                                " ('Malagasy (Madagascar)','mg-MG')," +
                                                " ('Malay (Brunei Darussalam)','ms-BN')," +
                                                " ('Malay (Malaysia)','ms-MY')," +
                                                " ('Malayalam (India)','ml-IN')," +
                                                " ('Maltese (Malta)','mt-MT')," +
                                                " ('Maori (New Zealand)','mi-NZ')," +
                                                " ('Mapudungun (Chile)','arn-CL')," +
                                                " ('Marathi (India)','mr-IN')," +
                                                " ('Mohawk (Mohawk)','moh-CA')," +
                                                " ('Mongolian (Cyrillic, Mongolia)','mn-MN')," +
                                                " ('Mongolian (Traditional Mongolian, China)','mn-Mong-CN')," +
                                                " ('Mongolian (Traditional Mongolian, Mongolia)','mn-Mong-MN')," +
                                                " ('Nepali (India)','ne-IN')," +
                                                " ('Nepali (Nepal)','ne-NP')," +
                                                " ('Nko (Guinea)','nqo-GN')," +
                                                " ('Norwegian, Bokmål (Norway)','nb-NO')," +
                                                " ('Norwegian, Nynorsk (Norway)','nn-NO')," +
                                                " ('Occitan (France)','oc-FR')," +
                                                " ('Odia (India)','or-IN')," +
                                                " ('Oromo (Ethiopia)','om-ET')," +
                                                " ('Pashto (Afghanistan)','ps-AF')," +
                                                " ('Persian','fa-IR')," +
                                                " ('Polish (Poland)','pl-PL')," +
                                                " ('Portuguese (Angola)','pt-AO')," +
                                                " ('Portuguese (Brazil)','pt-BR')," +
                                                " ('Portuguese (Portugal)','pt-PT')," +
                                                " ('Punjabi (India)','pa-IN')," +
                                                " ('Punjabi (Pakistan)','pa-Arab-PK')," +
                                                " ('Quechua (Bolivia)','quz-BO')," +
                                                " ('Quechua (Peru)','quz-PE')," +
                                                " ('Quichua (Ecuador)','quz-EC')," +
                                                " ('Romanian (Moldova)','ro-MD')," +
                                                " ('Romanian (Romania)','ro-RO')," +
                                                " ('Romansh (Switzerland)','rm-CH')," +
                                                " ('Russian (Russia)','ru-RU')," +
                                                " ('Sakha (Russia)','sah-RU')," +
                                                " ('Sami, Inari (Finland)','smn-FI')," +
                                                " ('Sami, Lule (Norway)','smj-NO')," +
                                                " ('Sami, Lule (Sweden)','smj-SE')," +
                                                " ('Sami, Northern (Finland)','se-FI')," +
                                                " ('Sami, Northern (Norway)','se-NO')," +
                                                " ('Sami, Northern (Sweden)','se-SE')," +
                                                " ('Sami, Skolt (Finland)','sms-FI')," +
                                                " ('Sami, Southern (Norway)','sma-NO')," +
                                                " ('Sami, Southern (Sweden)','sma-SE')," +
                                                " ('Sanskrit (India)','sa-IN')," +
                                                " ('Scottish Gaelic (United Kingdom)','gd-GB')," +
                                                " ('Serbian (Cyrillic, Bosnia and Herzegovina)','sr-Cyrl-BA')," +
                                                " ('Serbian (Cyrillic, Montenegro)','sr-Cyrl-ME')," +
                                                " ('Serbian (Cyrillic, Serbia and Montenegro (Former))','sr-Cyrl-CS')," +
                                                " ('Serbian (Cyrillic, Serbia)','sr-Cyrl-RS')," +
                                                " ('Serbian (Latin, Bosnia and Herzegovina)','sr-Latn-BA')," +
                                                " ('Serbian (Latin, Montenegro)','sr-Latn-ME')," +
                                                " ('Serbian (Latin, Serbia and Montenegro (Former))','sr-Latn-CS')," +
                                                " ('Serbian (Latin, Serbia)','sr-Latn-RS')," +
                                                " ('Sesotho sa Leboa (South Africa)','nso-ZA')," +
                                                " ('Setswana (Botswana)','tn-BW')," +
                                                " ('Setswana (South Africa)','tn-ZA')," +
                                                " ('Shona (Latin, Zimbabwe)','sn-Latn-ZW')," +
                                                " ('Sindhi (Pakistan)','sd-Arab-PK')," +
                                                " ('Sinhala (Sri Lanka)','si-LK')," +
                                                " ('Slovak (Slovakia)','sk-SK')," +
                                                " ('Slovenian (Slovenia)','sl-SI')," +
                                                " ('Somali (Somalia)','so-SO')," +
                                                " ('Southern Sotho (South Africa)','st-ZA')," +
                                                " ('Spanish (Argentina)','es-AR')," +
                                                " ('Spanish (Bolivarian Republic of Venezuela)','es-VE')," +
                                                " ('Spanish (Bolivia)','es-BO')," +
                                                " ('Spanish (Chile)','es-CL')," +
                                                " ('Spanish (Colombia)','es-CO')," +
                                                " ('Spanish (Costa Rica)','es-CR')," +
                                                " ('Spanish (Dominican Republic)','es-DO')," +
                                                " ('Spanish (Ecuador)','es-EC')," +
                                                " ('Spanish (El Salvador)','es-SV')," +
                                                " ('Spanish (Guatemala)','es-GT')," +
                                                " ('Spanish (Honduras)','es-HN')," +
                                                " ('Spanish (Latin America)','es-419')," +
                                                " ('Spanish (Mexico)','es-MX')," +
                                                " ('Spanish (Nicaragua)','es-NI')," +
                                                " ('Spanish (Panama)','es-PA')," +
                                                " ('Spanish (Paraguay)','es-PY')," +
                                                " ('Spanish (Peru)','es-PE')," +
                                                " ('Spanish (Puerto Rico)','es-PR')," +
                                                " ('Spanish (Spain, International Sort)','es-ES')," +
                                                " ('Spanish (United States)','es-US')," +
                                                " ('Spanish (Uruguay)','es-UY')," +
                                                " ('Standard Morrocan Tamazight (Tifinagh, Morocco)','zgh-Tfng-MA')," +
                                                " ('Swedish (Finland)','sv-FI')," +
                                                " ('Swedish (Sweden)','sv-SE')," +
                                                " ('Syriac (Syria)','syr-SY')," +
                                                " ('Tajik (Cyrillic, Tajikistan)','tg-Cyrl-TJ')," +
                                                " ('Tamil (India)','ta-IN')," +
                                                " ('Tamil (Sri Lanka)','ta-LK')," +
                                                " ('Tatar (Russia)','tt-RU')," +
                                                " ('Telugu (India)','te-IN')," +
                                                " ('Thai (Thailand)','th-TH')," +
                                                " ('Tibetan (China)','bo-CN')," +
                                                " ('Tigrinya (Eritrea)','ti-ER')," +
                                                " ('Tigrinya (Ethiopia)','ti-ET')," +
                                                " ('Tsonga (South Africa)','ts-ZA')," +
                                                " ('Turkish (Turkey)','tr-TR')," +
                                                " ('Turkmen (Turkmenistan)','tk-TM')," +
                                                " ('Ukrainian (Ukraine)','uk-UA')," +
                                                " ('Upper Sorbian (Germany)','hsb-DE')," +
                                                " ('Urdu (India)','ur-IN')," +
                                                " ('Urdu (Pakistan)','ur-PK')," +
                                                " ('Uyghur (China)','ug-CN')," +
                                                " ('Uzbek (Cyrillic, Uzbekistan)','uz-Cyrl-UZ')," +
                                                " ('Uzbek (Latin, Uzbekistan)','uz-Latn-UZ')," +
                                                " ('Valencian (Spain)','ca-ES-valencia')," +
                                                " ('Vietnamese (Vietnam)','vi-VN')," +
                                                " ('Welsh (United Kingdom)','cy-GB')," +
                                                " ('Wolof (Senegal)','wo-SN')," +
                                                " ('Yi (China)','ii-CN')," +
                                                " ('Yoruba (Nigeria)','yo-NG');";
                            SQLNonQuery(sqlSchema);

                            sqlSchema = null;
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                dt = null;
            }
            catch (Exception)
            {
                dt = null;
            }
        }
        #endregion
        #region Program
        public static DataTable ProgramData(string Table, string field, string condition)
        {
            string SQL = $"SELECT * FROM riskEngine.{Table} where {field} = '{condition}'";
            return SQLDataTable(SQL);
        }
        public static DataTable ProgramData(string Table)
        {
            string SQL = $"SELECT * FROM riskEngine.{Table}";
            return SQLDataTable(SQL);
        }
        #endregion
        #region generalSQL
        public static void SQLNonQuery(string SQL)
        {
            using (SqlConnection sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(SQL, sqlConnection))
                {
                    sqlConnection.Open();
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message + "\n\n" + SQL, "GeneralQuery", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlConnection.Close();
                    }
                }
            }
        }
        public static void SQLNonQuery(string SQL, DateTime date)
        {
            using (SqlConnection sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(SQL, sqlConnection))
                {
                    sqlCmd.Parameters.Add("@GeneralDate", SqlDbType.DateTime).Value = date;

                    sqlConnection.Open();
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message + "\n\n" + SQL, "GeneralQuery", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlConnection.Close();
                    }
                }
            }
        }

        public static void SQLNonQuery(string SQL, string SQLConnector)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SQLConnector))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(SQL, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static DataTable SQLDataTable(string SQL)
        {
            using (var dt = new DataTable())
            {
                try
                {
                    using (var sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
                    {
                        using (var da = new SqlDataAdapter(SQL, sqlConnection))
                        {
                            da.Fill(dt);
                            sqlConnection.Open();
                            return dt;
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }


        }
        public static DataTable SQLDataTable(string SQL, string SQLConnection)
        {
            using (var dt = new DataTable())
            {
                try
                {
                    using (var sqlConnection = new SqlConnection(SQLConnection))
                    {
                        using (var da = new SqlDataAdapter(SQL, sqlConnection))
                        {
                            da.Fill(dt);
                            sqlConnection.Open();
                            return dt;
                        }
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static bool evaluateConnectionString(string connectionString)
        {
            try
            {
                if (connectionString == "")
                {
                    return false;
                }
                DbConnectionStringBuilder cs = new DbConnectionStringBuilder();
                cs.ConnectionString = connectionString;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        #endregion

        #region specialSQL
        public static void SQLConnectorImportPreviewResetNonQuery(string SQL, Connector connector, string FilePath)
        {
            using (SqlConnection sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(SQL, sqlConnection))
                {
                    sqlCmd.Parameters.Add("@JobImportIK", SqlDbType.NVarChar, 50).Value = "1";
                    sqlCmd.Parameters.Add("@Import", SqlDbType.NVarChar, 50).Value = "Preview";
                    sqlCmd.Parameters.Add("@ConnectorIK", SqlDbType.Int).Value = connector.ConnectorIK;
                    sqlCmd.Parameters.Add("@JobIK", SqlDbType.Int).Value = 0;
                    sqlCmd.Parameters.Add("@FilePath", SqlDbType.NVarChar).Value = FilePath;
                    sqlCmd.Parameters.Add("@LogFile", SqlDbType.Text).Value = "";
                    sqlCmd.Parameters.Add("@Created", SqlDbType.DateTime).Value = DateTime.Now.ToString().ToString();

                    sqlConnection.Open();
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Preview Reset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlConnection.Close();
                    }
                }
            }
        }
        public static void SQLExternalDataTypeNonQuery(string SQL, DataType.Field field)
        {
            using (SqlConnection sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
            {
                using (SqlCommand sqlCmd = new SqlCommand(SQL, sqlConnection))
                {
                    sqlCmd.Parameters.Add("@ConnectorIK", SqlDbType.Int).Value = field.ConnectorIK;
                    sqlCmd.Parameters.Add("@FieldTypeRank", SqlDbType.Int).Value = field.FieldTypeRank;
                    sqlCmd.Parameters.Add("@FieldName", SqlDbType.NVarChar, 50).Value = field.FieldName;
                    sqlCmd.Parameters.Add("@FieldType", SqlDbType.NVarChar, 50).Value = field.FieldType;
                    sqlCmd.Parameters.Add("@FieldLength", SqlDbType.Int).Value = field.FieldLength;
                    sqlCmd.Parameters.Add("@FieldDecimals", SqlDbType.Int).Value = field.FieldDecimals;


                    sqlConnection.Open();
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "External Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlConnection.Close();
                    }
                }
            }
        }
        public static void SQLParsedDataNonQuery(Connector connector, DataTable dtParsed)
        {
            foreach (DataRow row in dtParsed.Rows)
            {
                using (SqlConnection sqlConnection = new SqlConnection(riskEngineIO.Properties.Settings.Default.conenctionString))
                {
                    string SQL = $"INSERT INTO [{connector.Schema}{connector.Schema2}].[{connector.Table}] (";
                    string SQLValues = ") VALUES(";
                    foreach (DataColumn col in dtParsed.Columns)
                    {
                        SQL = $"{SQL}[{col.ColumnName}], ";
                        SQLValues = $"{SQLValues}@{col.ColumnName}, ";
                    }
                    SQL = $"{SQL}d{SQLValues}d)";
                    SQL = SQL.Replace(", d", "");
                    SQLValues = null;

                    using (SqlCommand sqlCmd = new SqlCommand(SQL, sqlConnection))
                    {
                        var sqlDBType = Conversions.Type2SQLDbType();
                        foreach (DataColumn col in dtParsed.Columns)
                        {
                            col.GetType();
                            string para = $"@{col.ColumnName}";
                            if(sqlDBType[col.DataType].ToString() == "decimal")
                            {

                            }
                            sqlCmd.Parameters.Add(para, sqlDBType[col.DataType]).Value = row[col.ColumnName];
                        }
                        sqlConnection.Open();
                        try
                        {
                            sqlCmd.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Parsed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sqlConnection.Close();
                        }
                    }
                    SQL = null;
                }
            }
        }
        #endregion
    }
}