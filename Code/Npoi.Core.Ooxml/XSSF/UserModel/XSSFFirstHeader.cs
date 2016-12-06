/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */

using Npoi.Core.OpenXmlFormats.Spreadsheet;
using Npoi.Core.SS.UserModel;
using Npoi.Core.XSSF.UserModel.Extensions;
using System;

namespace Npoi.Core.XSSF.UserModel
{
    /**
     *
     * First page header content. Corresponds to first printed page.
     * The first logical page in the sheet may not be printed, for example, if the print area is specified to
     * be a range such that it falls outside the first page's scope.
     *
     */

    public class XSSFFirstHeader : XSSFHeaderFooter, IHeader
    {
        /**
         * Create an instance of XSSFFirstHeader from the supplied XML bean
         * @see XSSFSheet#getFirstHeader()
         * @param headerFooter
         */

        public XSSFFirstHeader(CT_HeaderFooter headerFooter)
            : base(headerFooter)
        {
            headerFooter.differentFirst = (true);
        }

        /**
         * Get the content text representing this header
         * @return text
         */

        public override String Text
        {
            get
            {
                return GetHeaderFooter().firstHeader;
            }
            set
            {
                if (value == null)
                {
                    GetHeaderFooter().firstHeader = null;
                }
                else
                {
                    GetHeaderFooter().firstHeader = (value);
                }
            }
        }
    }
}