﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Schema;

using iTin.Export.Helper;
using iTin.Export.Model;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// Base class for the different export types.
    /// Which acts as the base class for the different export types.
    /// </summary>
    /// <remarks>
    ///   <para>
    ///   The following table shows the different export types.
    ///   </para>
    ///   <list type="table">
    ///     <listheader>
    ///       <term>Class</term>
    ///       <description>Description</description>
    ///     </listheader>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.DataRowInput" /></term>
    ///       <description>Represents an exporter for array of <see cref="T:System.Data.DataRow"/> types. For more information please see <see cref="T:iTin.Export.DataRowInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.DataSetInput" /></term>
    ///       <description>Represents an exporter for <see cref="T:System.Data.DataSet"/> types. For more information please see <see cref="T:iTin.Export.DataSetInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.DataTableInput" /></term>
    ///       <description>Represents an exporter for <see cref="T:System.Data.DataTable"/> types. For more information please see <see cref="T:iTin.Export.DataTableInput" /></description>
    ///     </item>
    ///     <item>
    ///       <term><see cref="T:iTin.Export.XmlInput" /></term>
    ///       <description>Represents an exporter for <see cref="T:System.Data.DataSet"/> types. For more information please see <see cref="T:iTin.Export.XmlInput" /></description>
    ///     </item>
    ///   </list>
    /// </remarks>
    public abstract class BaseInput : IInput
    {
        #region Field Members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly InputExtendedInformation extendedInformation;
        #endregion

        #region Constructor/s

            #region [protected] BaseInput(): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="BaseInput" /> class.
            /// </summary>
            /// <param name="data">The data.</param>
            protected BaseInput(object data)
            {
                Data = data;
                extendedInformation = new InputExtendedInformation(this);
            }
            #endregion

        #endregion

        #region Public Properties

            #region [public] (object) Data: Gets a reference that contains the input data to export.
            /// <summary>
            /// Gets a reference that contains the input data to export.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.Object"/> that contains the input data to export.
            /// </value>
            public object Data
            {
                get; protected set;
            }
            #endregion

            #region [public] (InputExtendedInformation) ExtendedInformation: Gets a reference that contains the extended information about this input.
            /// <summary>
            /// Gets a reference that contains the extended information about this input.
            /// </summary>
            /// <value>
            /// A <see cref="T:iTin.Export.ComponentModel.TargetExtendedInformation"/> that contains the extended information about this input.
            /// </value>
            public InputExtendedInformation ExtendedInformation
            {
                get { return extendedInformation; }
            }
            #endregion

        #endregion

        #region Public Methods

            #region [public] (void) Export(ExportSettings): Exports the input data using the specified configuration in xml configuration file.
            /// <summary>
            /// Exports the input data using the specified configuration in xml configuration file.
            /// </summary>
            /// <remarks>
            /// If <see cref="P:iTin.Export.ExportSettings.From" /> is <c>null</c> or <see cref="System.String.Empty"/>, 
            /// always use the first section with <see cref="P:iTin.Export.Model.ExportModel.Current" /> attribute sets to <see cref="iTin.Export.Model.YesNo.Yes"/>.
            /// </remarks>
            /// <param name="settings">Export settings</param>
            public void Export(ExportSettings settings)
            {
                SentinelHelper.ArgumentNull(settings);

                Uri configuration;
                var hasConfiguration = ExportSettings.TryGetConfigurationFile(settings, out configuration);
                if (!hasConfiguration)
                {
                    return;
                }

                var root = LoadModelFrom(configuration);
                if (root == null)
                {
                    return;
                }

                ////exportModel = string.IsNullOrEmpty(settings.From)
                ////             ? root.Exports.FirstOrDefault(e => e.Current == YesNo.Yes)
                ////             : root.Exports[settings.From]; 

                var clausuleFrom = settings.From;
                var httpExpSettings = settings as HttpExportSettings;
                if (httpExpSettings != null)
                {
                    clausuleFrom = httpExpSettings.Settings.From;
                }

                var exportModel = string.IsNullOrEmpty(clausuleFrom)
                                      ? root.Items.FirstOrDefault(e => e.Current == YesNo.Yes)
                                      : root.Items.SingleOrDefault(e => e.Name.Equals(clausuleFrom));

                if (exportModel == null)
                {
                    return;
                }

                //exportModel.Table.Fields.Validate();
                //exportModel.Table.Charts.Validate();

                //exportModel.CallingAssemblyPath = Assembly.GetCallingAssembly().CodeBase.ToUpperInvariant();
                var httpSettings = settings as HttpExportSettings;
                if (httpSettings != null)
                {
                    //exportModel.CallingAssemblyPath = httpSettings.BasePath;
                }

                var cache = AdaptersCache.Instance(this);
                var adapter = cache.GetAdapter(ExtendedInformation);
                var targetDataModel = new AdapterDataModel { Data = exportModel, Resources = root.Resources, References = root.References };
                adapter.SetDataModel(targetDataModel);
                adapter.Export(settings);

                //// Proceso de validación.
                ////var aaa = root.Items[0].BlockLines[0];
                ////ValidationContext validationContext = new ValidationContext(aaa, null, null);
                ////List<ValidationResult> errors = new List<ValidationResult>();
                ////Validator.TryValidateObject(aaa, validationContext, errors, true);
                
                //// Si hay errores, los recorremos y los mostramos (versión demo).            
                ////if (errors.Any())
                ////{
                ////    string errorMessages = string.Empty;
                ////    foreach (var error in errors)
                ////    {
                ////        errorMessages += error.ErrorMessage + Environment.NewLine;
                ////    }
                ////    //MessageBox.Show(errorMessages);
                ////}
                ////else
                ////{
                ////    var ss = "OK";
                ////    //MessageBox.Show("Entidad correcta");
                ////}


                ////var s = ((TextLineModel)root.Resources.Lines[1]).GetStyle();
            }
            #endregion

        #endregion

        #region Private Static Methods

            #region [private] {static} (RootDocumentModel) LoadModelFrom(Uri): Import general properties from a configuration file.
            /// <summary>
            /// Import general properties from a configuration file.
            /// </summary>
            /// <param name="configuration">The configuration.</param>
            /// <returns>
            /// RootModel object
            /// </returns>
            /// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">Occurs if the model contains errors.</exception>
            /// <exception cref="T:System.InvalidOperationException">Occurs if a style assigned to a field is blank or does not exist.</exception>
            /// <exception cref="T:System.IO.FileNotFoundException">Occurs if not found the path to configuration file.</exception>
            private static ExportsModel LoadModelFrom(Uri configuration)
            {
                ExportsModel model;

                try
                {
                    model = ExportsModel.LoadFromFile(configuration.OriginalString);
                }
                catch (InvalidOperationException ex)
                {
                    var modelErrorMessage = new StringBuilder();
                    modelErrorMessage.AppendLine(ex.Message);
                    var inner = ex.InnerException;
                    while (true)
                    {
                        if (inner == null)
                        {
                            break;
                        }

                        modelErrorMessage.AppendLine(inner.Message);
                        inner = inner.InnerException;
                    }

                    throw new XmlSchemaValidationException(modelErrorMessage.ToString());
                }

                return model;
            }
            #endregion

        #endregion
    }
}
