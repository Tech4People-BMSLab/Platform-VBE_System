using CaptureManagerToCSharpProxy.Interfaces;
using System.Collections.Generic;

namespace VBEApp_v1._0
{
    class FileSink : AbstractSink
    {
        string mFilePath = null;

        IFileSinkFactory mSinkFactory = null;

        public FileSink(IFileSinkFactory aSinkFactory)
        {
            mSinkFactory = aSinkFactory;
        }

        public override void setOptions(string aOptions)
        {
            mFilePath = aOptions;
        }

        public override object getOutputNode(object aUpStreamMediaType)
        {

            List<object> lCompressedMediaTypeList = new List<object>();

            lCompressedMediaTypeList.Add(aUpStreamMediaType);

            List<object> lTopologyOutputNodesList;

            mSinkFactory.createOutputNodes(
                lCompressedMediaTypeList,
                mFilePath,
                out lTopologyOutputNodesList);

            if (lTopologyOutputNodesList.Count == 0)
                return null;

            return lTopologyOutputNodesList[0];
        }
    }
}
