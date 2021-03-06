﻿using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace iTin.Export.Model
{
    /// <summary>
    /// Includes the description and data table definition to export. 
    /// </summary>
    /// <remarks>
    /// <para>Belongs to: <strong><c>Exports</c></strong>. For more information, please see <see cref="T:iTin.Export.Model.ExportsModel"/>.<br/>
    /// <code lang="xml" title="AEE Object Element Usage">
    /// &lt;Global.Resources&gt;
    ///   &lt;Fixed/&gt;
    ///   &lt;Groups/&gt;
    ///   &lt;Hosts/&gt;
    ///   &lt;Images/&gt;
    ///   &lt;Lines/&gt;
    ///   &lt;Styles/&gt;
    /// &lt;/Global.Resources&gt;
    /// </code>
    /// </para>
    /// <para><strong>Elements</strong></para>
    /// <list type="table">
    ///   <listheader>
    ///     <term>Element</term>
    ///     <description>Description</description>
    ///   </listheader>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.GlobalResourcesModel.Images" /></term> 
    ///     <description>Description of the export.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.GlobalResourcesModel.Fixed" /></term>
    ///     <description>Collection of user-defined pieces. Each element is a collection of smaller pieces result of splitting the reference field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.GlobalResourcesModel.Groups" /></term>
    ///     <description>Collection of user-defined groups. Each element is result from the union of several data field.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.GlobalResourcesModel.Lines" /></term>
    ///     <description>Collection of user-defined lines. Each element is result from the union of lines.</description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="P:iTin.Export.Model.GlobalResourcesModel.Styles" /></term>
    ///     <description>Collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.</description>
    ///   </item>
    /// </list>
    /// <para>
    /// <para><strong>Compatibility table with native writers.</strong></para>
    /// <table>
    ///   <thead>
    ///     <tr>
    ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
    ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
    ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
    ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
    ///     </tr>
    ///   </thead>
    ///   <tbody>
    ///     <tr>
    ///       <td align="center">X</td>
    ///       <td align="center">X</td>
    ///       <td align="center">X</td>
    ///       <td align="center">X</td>
    ///     </tr>
    ///   </tbody>
    /// </table>
    /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
    /// </para>
    /// </remarks>
    public partial class GlobalResourcesModel
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExportsModel _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FixedModel _fix;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupsModel _groups;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HostsModel _hosts;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private LinesModel _lines;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StylesModel _styles;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ImagesModel _images;
        #endregion

        #region public properties

            #region [public] (ExportsModel) Parent: Gets the parent element of the element.
            /// <summary>
            /// Gets the parent element of the element.
            /// </summary>
            /// <value>
            /// The element that represents the container element of the element.
            /// </value>
            [XmlIgnore]
            [Browsable(false)]
            public ExportsModel Parent
            {
                get { return _parent; }
            }
            #endregion

            #region [public] (FixedModel) Fixed: Gets or sets collection of user-defined pieces.
            /// <summary>
            /// Gets or sets collection of user-defined pieces.
            /// </summary>
            /// <value>
            /// Collection of user-defined pieces. Each element is a collection of smaller pieces result of splitting the reference field.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Global.Resources&gt;
            ///   &lt;Fixed .../&gt;
            ///   ...
            /// &lt;/Global.Resources&gt;
            /// </code>
            /// <para>
            /// <para><strong>Compatibility table with native writers.</strong></para>
            /// <table>
            ///   <thead>
            ///     <tr>
            ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
            ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
            ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
            ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
            ///     </tr>
            ///   </thead>
            ///   <tbody>
            ///     <tr>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            [XmlArrayItem("Pieces", typeof(FixedItemModel), IsNullable = false)]
            public FixedModel Fixed
            {
                get
                {
                    return _fix ?? (_fix = new FixedModel(this));
                }
                set
                {
                    _fix = value;                    
                }
            }
            #endregion

            #region [public] (GroupsModel) Groups: Gets or sets the collection of user-defined styles.
            /// <summary>
            /// Gets or sets collection of user-defined groups.
            /// </summary>
            /// <value>
            /// Collection of user-defined groups. Each element is result from the union of several data field.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Global.Resources&gt;
            ///   &lt;Groups .../&gt;
            ///   ...
            /// &lt;/Global.Resources&gt;
            /// </code>
            /// <para>
            /// <para><strong>Compatibility table with native writers.</strong></para>
            /// <table>
            ///   <thead>
            ///     <tr>
            ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
            ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
            ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
            ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
            ///     </tr>
            ///   </thead>
            ///   <tbody>
            ///     <tr>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            [XmlArrayItem("Group", typeof(GroupModel), IsNullable = false)]
            public GroupsModel Groups
            {
                get
                {
                    return _groups ?? (_groups = new GroupsModel(this));
                }
                set
                {
                    _groups = value;                     
                }
            }
            #endregion

            #region [public] (HostsModel) Hosts: Gets or sets the collection of user-defined styles.
            /// <summary>
            /// Gets or sets collection of user-defined groups.
            /// </summary>
            /// <value>
            /// Collection of user-defined groups. Each element is result from the union of several data field.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Global.Resources&gt;
            ///   &lt;Groups .../&gt;
            ///   ...
            /// &lt;/Global.Resources&gt;
            /// </code>
            /// <para>
            /// <para><strong>Compatibility table with native writers.</strong></para>
            /// <table>
            ///   <thead>
            ///     <tr>
            ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
            ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
            ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
            ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
            ///     </tr>
            ///   </thead>
            ///   <tbody>
            ///     <tr>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            [XmlArrayItem("Host", typeof(HostModel), IsNullable = false)]
            public HostsModel Hosts
            {
                get
                {
                    return _hosts ?? (_hosts = new HostsModel(this));
                }
                set
                {
                    _hosts = value;
                }
            }
            #endregion

            #region [public] (ImagesModel) Images: Gets or sets the collection of user-defined styles.
            /// <summary>
            /// Gets or sets the collection of user-defined styles.
            /// </summary>
            /// <value>
            /// Collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Global.Resources&gt;
            ///   &lt;Images .../&gt;
            ///   ...
            /// &lt;/Global.Resources&gt;
            /// </code>
            /// <para>
            /// <para><strong>Compatibility table with native writers.</strong></para>
            /// <table>
            ///   <thead>
            ///     <tr>
            ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
            ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
            ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
            ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
            ///     </tr>
            ///   </thead>
            ///   <tbody>
            ///     <tr>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            [XmlArrayItem("Image", typeof(ImageModel), IsNullable = false)]
            public ImagesModel Images
            {
                get
                {
                    return _images ?? (_images = new ImagesModel(this));
                }
                set
                {
                    _images = value;
                }
            }
            #endregion

            #region [public] (LinesModel) Lines: Gets or sets collection of lines.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Table/Public/Properties/Property[@name="Lines"]/*'/>
            [XmlArrayItem("TextLine", typeof(TextLineModel))]
            [XmlArrayItem("EmptyLine", typeof(EmptyLineModel))]
            public LinesModel Lines
            {
                get
                {
                    return _lines ?? (_lines = new LinesModel(this));
                }
                set
                {
                    _lines = value;
                }
            }
            #endregion

            #region [public] (StylesModel) Styles: Gets or sets the collection of user-defined styles.
            /// <summary>
            /// Gets or sets the collection of user-defined styles.
            /// </summary>
            /// <value>
            /// Collection of user-defined styles. Each element defines type of content, such as the background color, the alignment type, the data type and the font type.
            /// </value>
            /// <remarks>
            /// <code lang="xml" title="AEE Object Element Usage">
            /// &lt;Global.Resources&gt;
            ///   &lt;Styles .../&gt;
            ///   ...
            /// &lt;/Global.Resources&gt;
            /// </code>
            /// <para>
            /// <para><strong>Compatibility table with native writers.</strong></para>
            /// <table>
            ///   <thead>
            ///     <tr>
            ///       <th>Comma-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.CsvWriter" /></th>
            ///       <th>Tab-Separated Values<br/><see cref="T:iTin.Export.Writers.Native.TsvWriter" /></th>
            ///       <th>SQL Script<br/><see cref="T:iTin.Export.Writers.Native.SqlScriptWriter" /></th>
            ///       <th>XML Spreadsheet 2003<br/><see cref="T:iTin.Export.Writers.Native.Spreadsheet2003TabularWriter" /></th>
            ///     </tr>
            ///   </thead>
            ///   <tbody>
            ///     <tr>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///       <td align="center">X</td>
            ///     </tr>
            ///   </tbody>
            /// </table>
            /// A <strong><c>X</c></strong> value indicates that the writer supports this element.
            /// </para>
            /// </remarks>
            [XmlArrayItem("Style", typeof(StyleModel), IsNullable = false)]
            public StylesModel Styles
            {
                get
                {
                    return _styles ?? (_styles = new StylesModel(this));
                }
                set
                {
                    _styles = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance is default.
            /// <summary>
            /// Gets a value indicating whether this instance is default.
            /// </summary>
            /// <value>
            /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
            /// </value>
            public override bool IsDefault
            {
                get
                {
                    return
                        Fixed.IsDefault &&
                        Groups.IsDefault &&
                        Hosts.IsDefault &&
                        Images.IsDefault &&
                        Lines.IsDefault &&
                        Styles.IsDefault;
                }
            }
            #endregion

        #endregion

        #region public methods

            #region [public] (object) GetResourceByKey(string): Gets specified resource by key.
            /// <summary>
            /// Gets specified resource by key.
            /// </summary>
            /// <param name="key">Key of resource.</param>
            /// <returns>
            /// An <see cref="T:System.Object"/> which contains specified resource.
            /// </returns>
            public object GetResourceByKey(string key)
            {
                return Images.FirstOrDefault(image => image.Key == key);
            }
            #endregion

            #region [public] (ImageModel) GetImageResourceByKey(string): Gets specified image resource by key.
            /// <summary>
            /// Gets specified image resource by key.
            /// </summary>
            /// <param name="key">Key of resource.</param>
            /// <returns>
            /// A <see cref="T:iTin.Export.Model.ImageModel"/> which contains specified image resource.
            /// </returns>
            public ImageModel GetImageResourceByKey(string key)
            {
                return (ImageModel)GetResourceByKey(key);
            }
            #endregion

            #region [public] (StyleModel) GetStyleResourceByName(string): Gets specified style resource by name.
            /// <summary>
            /// Gets specified style resource by name.
            /// </summary>
            /// <param name="name">Name of style.</param>
            /// <returns>
            /// A <see cref="T:iTin.Export.Model.StyleModel"/> which contains specified style resource.
            /// </returns>
            public StyleModel GetStyleResourceByName(string name)
            {
                return Styles.FirstOrDefault(style => style.Name == name);
            }
            #endregion

        #endregion

        #region internal methods

            #region [internal] (void) SetParent(ExportsModel): Sets the parent element of the element.
            /// <summary>
            /// Sets the parent element of the element.
            /// </summary>
            /// <param name="reference">Reference to parent.</param>
            internal void SetParent(ExportsModel reference)
            {
                _parent = reference;
            }
            #endregion

        #endregion
    }
}
