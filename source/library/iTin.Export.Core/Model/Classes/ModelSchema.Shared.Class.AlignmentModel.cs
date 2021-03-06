﻿using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

using iTin.Export.Helper;

namespace iTin.Export.Model
{
    /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Alignment/Class[@name="info"]/*'/>
    public partial class AlignmentModel
    {
        #region private constants
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const int DefaultSkipLines = 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const KnownHorizontalAlignment DefaultHorizontal = KnownHorizontalAlignment.Center;
        #endregion

        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int lines;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private KnownHorizontalAlignment horizontal;
        #endregion

        #region constructor/s

            #region [public] AlignmentModel(): Initializes a new instance of this class.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Alignment/Public/Constructors/Constructor[@name="ctor1"]/*'/>
            public AlignmentModel()
            {
                SkipLines = DefaultSkipLines;
                Horizontal = DefaultHorizontal;
            }
            #endregion

        #endregion

        #region public properties

            #region [public] (KnownHorizontalAlignment) Horizontal: Gets or sets horizontal alignment.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Alignment/Public/Properties/Property[@name="Horizontal"]/*'/>
            [XmlAttribute]
            [DefaultValue(DefaultHorizontal)]
            public KnownHorizontalAlignment Horizontal
            {
                get
                {
                    return horizontal;
                }
                set
                {
                    SentinelHelper.IsEnumValid(value);
                    horizontal = value;
                }
            }
            #endregion

            #region [public] (int) SkipLines: Gets or sets number of lines to skip.
            /// <include file='..\..\iTin.Export.Documentation.xml' path='Model/Alignment/Public/Properties/Property[@name="SkipLines"]/*'/>
            [XmlAttribute]
            [DefaultValue(DefaultSkipLines)]
            public int SkipLines
            {
                get
                {
                    return lines;
                }
                set
                {
                    SentinelHelper.IsTrue(value < 0, "El número de lineas no puede ser menor que cero");
                    lines = value;
                }
            }
            #endregion

        #endregion

        #region public override properties

            #region [public] {overide} (bool) IsDefault: Gets a value indicating whether this instance contains the default.
            /// <include file='..\..\iTin.Export.Documentation.Common.xml' path='Common/Model/Public/Overrides/Properties/Property[@name="IsDefault"]/*'/>
            [Browsable(false)]
            public override bool IsDefault
            {
                get
                {
                    return 
                        SkipLines.Equals(DefaultSkipLines) && 
                        Horizontal.Equals(DefaultHorizontal);
                }
            }
            #endregion

        #endregion
    }
}
