using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLPositionMapper
{
    class ResultXMLProcess
    {
        public static List<String> loadUnprocessedBalanceSheetPositions(string path)
        {
            List<string> unprocessedBalanceSheetPositions = new List<string>();
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNodeList xnList = xml.SelectNodes("/FinancialStatement[@*]/Balance_Sheet_IFRS/NotProcessedPositions");
            foreach (XmlNode xn in xnList)
            {
                XmlNodeList example = xn.SelectNodes("NotProcessedPosition");
                foreach (XmlNode ex in example)
                {
                    unprocessedBalanceSheetPositions.Add(ex.InnerText);
                }
            }
            return unprocessedBalanceSheetPositions;

        }

        public static List<String> loadUnprocessedCashFlowPositions(string path)
        {

            List<string> unprocessedCashFlowPositions = new List<string>();
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNodeList xnList = xml.SelectNodes("/FinancialStatement[@*]/Cashflows_Indirect_IFRS/NotProcessedPositions");
            foreach (XmlNode xn in xnList)
            {
                XmlNodeList example = xn.SelectNodes("NotProcessedPosition");
                foreach (XmlNode ex in example)
                {
                    unprocessedCashFlowPositions.Add(ex.InnerText);
                }
            }
            return unprocessedCashFlowPositions;

        }

        public static List<String> loadUnprocessedProfitAndLossPositions(string path)
        {
            List<string> unprocessedProfitAndLossPositions = new List<string>();
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            XmlNodeList xnList;

            if (xml.SelectNodes("/FinancialStatement[@*]/PROFIT_LOSS_FOE_IFRS/NotProcessedPositions").Count > 0)
            {
                xnList = xml.SelectNodes("/FinancialStatement[@*]/PROFIT_LOSS_FOE_IFRS/NotProcessedPositions");
                foreach (XmlNode xn in xnList)
                {
                    XmlNodeList example = xn.SelectNodes("NotProcessedPosition");
                    foreach (XmlNode ex in example)
                    {
                        unprocessedProfitAndLossPositions.Add(ex.InnerText);
                    }
                }
                return unprocessedProfitAndLossPositions;
            }
            else if (xml.SelectNodes("/FinancialStatement[@*]/PROFIT_LOSS_NOE_IFRS/NotProcessedPositions").Count > 0)
            {
                xnList = xml.SelectNodes("/FinancialStatement[@*]/PROFIT_LOSS_NOE_IFRS/NotProcessedPositions");
                foreach (XmlNode xn in xnList)
                {
                    XmlNodeList example = xn.SelectNodes("NotProcessedPosition");
                    foreach (XmlNode ex in example)
                    {
                        unprocessedProfitAndLossPositions.Add(ex.InnerText);
                    }
                }
                return unprocessedProfitAndLossPositions;
            }
            else
            {
                return null;
            }

        }

        public static List<String> getBalanceSheetPositionsList()
        {
            string path = PositionMapper.getMappingFilePath();

            List<string> balanceSheetPositionList = new List<string>();
            Console.WriteLine("getting balancesheet positions");

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList elemList = doc.SelectNodes("/XML/configuration/BalanceSheet/valueMap/mapping/targetPosition");
            for (int i = 0; i < elemList.Count; i++)
            {
                string attrVal = elemList[i].InnerText;
                if (!balanceSheetPositionList.Contains(attrVal))
                {
                    Console.WriteLine(elemList[i].InnerText);
                    balanceSheetPositionList.Add(elemList[i].InnerText);
                }

            }
            balanceSheetPositionList = balanceSheetPositionList.OrderBy(q => q).ToList();
            balanceSheetPositionList.Insert(0, "No Mapping");
            return balanceSheetPositionList;
        }

        public static List<String> getCashFlowPositionsList()
        {
            string path = PositionMapper.getMappingFilePath();

            List<string> cashFlowPositionList = new List<string>();
            Console.WriteLine("getting cashflow positions");

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList elemList = doc.SelectNodes("/XML/configuration/CashFlowStatement/valueMap/mapping/targetPosition");
            for (int i = 0; i < elemList.Count; i++)
            {
                string attrVal = elemList[i].InnerText;
                if (!cashFlowPositionList.Contains(attrVal))
                {
                    cashFlowPositionList.Add(elemList[i].InnerText);
                }

            }
            cashFlowPositionList = cashFlowPositionList.OrderBy(q => q).ToList();
            cashFlowPositionList.Insert(0, "No Mapping");
            return cashFlowPositionList;
        }

        public static List<String> getProfitAndLossPositionsList()
        {
            string path = PositionMapper.getMappingFilePath();
            List<string> profitAndLossPositionList = new List<string>();
            Console.WriteLine("getting profit and loss positions");

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList elemList = doc.SelectNodes("/XML/configuration/ProfitLossStatement/valueMap/mapping/targetPosition");
            for (int i = 0; i < elemList.Count; i++)
            {
                string attrVal = elemList[i].InnerText;
                if (!profitAndLossPositionList.Contains(attrVal))
                {
                    profitAndLossPositionList.Add(elemList[i].InnerText);
                }
            }

            profitAndLossPositionList = profitAndLossPositionList.OrderBy(q => q).ToList();
            profitAndLossPositionList.Insert(0, "No Mapping");

            return profitAndLossPositionList;
        }

        public static void updateMappedBalanceSheetPositions(DataGridView balanceSheetDataGridView)
        {
            string path = PositionMapper.getMappingFilePath();
            XmlDocument mappingXMLFile = new XmlDocument();
            mappingXMLFile.Load(path);


            foreach (DataGridViewRow row in balanceSheetDataGridView.Rows)
            {

                XmlNode element = mappingXMLFile.SelectSingleNode("/XML/configuration/BalanceSheet/valueMap");
                XmlNode mappingNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "mapping", null);

                XmlNode sourcePositionNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "sourcePosition", null);
                XmlNode targetPositionNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "targetPosition", null);

                mappingNode.AppendChild(sourcePositionNode);
                mappingNode.AppendChild(targetPositionNode);

                if (row.Cells["Unprocessed_Positions"].Value != null && !(row.Cells["Map_to_Position"].Value.ToString().Equals("No Mapping")))
                {
                    sourcePositionNode.InnerText = row.Cells["Unprocessed_Positions"].Value.ToString();
                    targetPositionNode.InnerText = row.Cells["Map_to_Position"].Value.ToString();
                    element.AppendChild(mappingNode);
                    mappingXMLFile.Save(path);
                }
            }
        }

        public static void updateMappedCashFlowPositions(DataGridView cashFlowDataGridView)
        {
            string path = PositionMapper.getMappingFilePath();
            XmlDocument mappingXMLFile = new XmlDocument();
            mappingXMLFile.Load(path);


            foreach (DataGridViewRow row in cashFlowDataGridView.Rows)
            {

                XmlNode element = mappingXMLFile.SelectSingleNode("/XML/configuration/CashFlowStatement/valueMap");
                XmlNode mappingNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "mapping", null);

                XmlNode sourcePositionNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "sourcePosition", null);
                XmlNode targetPositionNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "targetPosition", null);

                mappingNode.AppendChild(sourcePositionNode);
                mappingNode.AppendChild(targetPositionNode);

                if (row.Cells["Unprocessed_Positions"].Value != null && !(row.Cells["Map_to_Position"].Value.ToString().Equals("No Mapping")))
                {
                    sourcePositionNode.InnerText = row.Cells["Unprocessed_Positions"].Value.ToString();
                    targetPositionNode.InnerText = row.Cells["Map_to_Position"].Value.ToString();
                    element.AppendChild(mappingNode);
                    mappingXMLFile.Save(path);
                }
            }
        }

        public static void updateMappedProfitAndLossPositions(DataGridView profitAndLossDataGridView)
        {
            string path = PositionMapper.getMappingFilePath();
            XmlDocument mappingXMLFile = new XmlDocument();
            mappingXMLFile.Load(path);


            foreach (DataGridViewRow row in profitAndLossDataGridView.Rows)
            {

                XmlNode element = mappingXMLFile.SelectSingleNode("/XML/configuration/ProfitLossStatement/valueMap");
                XmlNode mappingNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "mapping", null);

                XmlNode sourcePositionNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "sourcePosition", null);
                XmlNode targetPositionNode = mappingXMLFile.CreateNode(XmlNodeType.Element, "targetPosition", null);

                mappingNode.AppendChild(sourcePositionNode);
                mappingNode.AppendChild(targetPositionNode);

                if (row.Cells["Unprocessed_Positions"].Value != null && !(row.Cells["Map_to_Position"].Value.ToString().Equals("No Mapping")))
                {
                    sourcePositionNode.InnerText = row.Cells["Unprocessed_Positions"].Value.ToString();
                    targetPositionNode.InnerText = row.Cells["Map_to_Position"].Value.ToString();
                    element.AppendChild(mappingNode);
                    mappingXMLFile.Save(path);
                }
            }
        }
    }
}
