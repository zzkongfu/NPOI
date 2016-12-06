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

namespace Npoi.Core.XWPF.UserModel
{
    public enum PictureType
    {
        /** Extended windows meta file */
        EMF = 2,

        /** Windows Meta File */
        WMF = 3,

        /** Mac PICT format */
        PICT = 4,

        /** JPEG format */
        JPEG = 5,

        /** PNG format */
        PNG = 6,

        /** Device independent bitmap */
        DIB = 7,

        /** GIF image format */
        GIF = 8,
        /**
         * Tag Image File (.tiff)
         */
        TIFF = 9,

        /**
         * Encapsulated Postscript (.eps)
         */
        EPS = 10,

        /**
         * Windows Bitmap (.bmp)
         */
        BMP = 11,

        /**
         * WordPerfect graphics (.wpg)
         */
        WPG = 12
    }

    public interface Document
    {
    }
}