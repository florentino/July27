
        public void BulkInsert(object[] objdata)
        {
            var icbsData = (DataTable)objdata[0];
            var aafData = (DataTable)objdata[1];
            var famsData = (ArrayList)objdata[2];


            List<DataRow> list = icbsData.AsEnumerable().ToList();

            using (var scope = context.Database.BeginTransaction())
            //using ( TransactionScope scope = new TransactionScope())
            {
                NTC_Context_Entities context = null;
                try
                {
                    context = new NTC_Context_Entities();

                    int count = 0;

                    foreach (var entityToInsert in list)
                    {
                        BDOLF_NTC_Consolidator item = new BDOLF_NTC_Consolidator();

                        // item.TransID = entityToInsert.ItemArray[0].ToString();
                        
                        item.AccountNo = entityToInsert.ItemArray[0].ToString();
                        item.ClientName = entityToInsert.ItemArray[1].ToString();
                        item.AO = entityToInsert.ItemArray[2].ToString();
                        item.FacilityCode = entityToInsert.ItemArray[3].ToString();
                        item.StatusPerSystem = entityToInsert.ItemArray[4].ToString();
                        item.ValueDate = entityToInsert.ItemArray[5].ToString();
                        // item.FirstDueDate = entityToInsert.ItemArray[6].ToString();
                        item.MaturityDate = entityToInsert.ItemArray[6].ToString();
                        item.TotalLoan = entityToInsert.ItemArray[7].ToString();
                        item.OB = entityToInsert.ItemArray[8].ToString();
                        item.MonthlyOB = entityToInsert.ItemArray[9].ToString();
                        //item.UDIBalance = Convert.ToDecimal(entityToInsert.ItemArray[11]);
                        //item.ClientsEquity = Convert.ToDecimal(entityToInsert.ItemArray[12]);
                        item.AccruedInterestReceivable = entityToInsert.ItemArray[10].ToString();
                        //item.OrigERV = Convert.ToDecimal(entityToInsert.ItemArray[13]);
                        //item.PVRV = Convert.ToDecimal(entityToInsert.ItemArray[14]);
                        //item.OrigGD = Convert.ToDecimal(entityToInsert.ItemArray[15]);
                        //item.PVGD = Convert.ToDecimal(entityToInsert.ItemArray[16]);
                        //item.TotalLoanPortfolio = Convert.ToDecimal(entityToInsert.ItemArray[17]);
                        //item.NTC = Convert.ToDecimal(entityToInsert.ItemArray[18]);
                        item.OriginalRate = entityToInsert.ItemArray[11].ToString();
                        item.CurrentRate = entityToInsert.ItemArray[12].ToString();
                        item.TermInMonths = entityToInsert.ItemArray[13].ToString();
                        //item.RemainingTermInMonths = entityToInsert.ItemArray[22].ToString();
                        //item.OriginalAmortizationAAF = Convert.ToDecimal(entityToInsert.ItemArray[23]);
                        //item.PaymentScheduleAmortizationAAF = Convert.ToDecimal(entityToInsert.ItemArray[24]);
                        //item.RepricedDate = entityToInsert.ItemArray[25].ToString();
                        item.AAFICBSRateType = entityToInsert.ItemArray[14].ToString();
                        //item.RepricedAmortization = Convert.ToDecimal(entityToInsert.ItemArray[27]);
                        item.PastDueDateITLDateExtractedPerAAFICBS = entityToInsert.ItemArray[15].ToString();
                        item.PerFaMSAAFICBSIndustryCode = entityToInsert.ItemArray[16].ToString();
                        item.IndustryHeader = entityToInsert.ItemArray[17].ToString();
                        item.IndustryDetail = entityToInsert.ItemArray[18].ToString();
                        item.Collateral = entityToInsert.ItemArray[19].ToString();
                        item.PerFaMSAAFICBSAssetSize = entityToInsert.ItemArray[20].ToString();
                        //item.PerFaMSAAFICBSAssetSizeInWords = entityToInsert.ItemArray[34].ToString();
                        //item.ICBSGLCode = entityToInsert.ItemArray[35].ToString();
                        //item.ICBSGLName = entityToInsert.ItemArray[36].ToString();
                        item.CostCenter = entityToInsert.ItemArray[21].ToString();
                        //item.BranchNameOfCostCenterPerSystem = entityToInsert.ItemArray[38].ToString();
                        //item.StatusPerGL = entityToInsert.ItemArray[39].ToString();
                        //item.OriginatingBranchBooked = entityToInsert.ItemArray[40].ToString();
                        item.NationalityPerICBS = entityToInsert.ItemArray[22].ToString();
                        item.NextRateReviewDateExtractedPerFaMSAAFICBS = entityToInsert.ItemArray[23].ToString();
                        item.TaxID = entityToInsert.ItemArray[24].ToString();
                        item.LoanPurposeCode = entityToInsert.ItemArray[25].ToString();
                        item.MaturityTypeCode = entityToInsert.ItemArray[26].ToString();
                        item.BankRelationship = entityToInsert.ItemArray[27].ToString();
                        item.SyndicatedLoanInd = entityToInsert.ItemArray[28].ToString();
                        item.CustomerTypeDescription = entityToInsert.ItemArray[29].ToString();
                        //item.RELCode = entityToInsert.ItemArray[49].ToString();
                        //item.REECode = entityToInsert.ItemArray[50].ToString();
                        //item.REEAddtlInfo = entityToInsert.ItemArray[51].ToString();
                        //item.AcctRef = entityToInsert.ItemArray[52].ToString();
                        item.RPT = entityToInsert.ItemArray[30].ToString();
                        //item.ASSETCOST = Convert.ToDecimal(entityToInsert.ItemArray[54].ToString());
                        //item.LeaseType = entityToInsert.ItemArray[55].ToString();
                        //item.Provisioning = entityToInsert.ItemArray[56].ToString();
                        //item.Matrix = entityToInsert.ItemArray[57].ToString();
                        //item.Remarks = entityToInsert.ItemArray[58].ToString();
                        item.ICBSCollateralCode = entityToInsert.ItemArray[31].ToString();
                        item.AssetValue =entityToInsert.ItemArray[32].ToString();
                        item.ApprovedAmount = entityToInsert.ItemArray[33].ToString();
                        //item.CPNumber = entityToInsert.ItemArray[62].ToString();
                        item.LastPrincipalPay = entityToInsert.ItemArray[34].ToString();
                        item.PrincipalPayDate = entityToInsert.ItemArray[35].ToString();
                        item.LastInterestPay = entityToInsert.ItemArray[36].ToString();
                        item.LastInterestPayDate = entityToInsert.ItemArray[37].ToString();
                        item.PreviousMonthsNPLTaggingByRisk = entityToInsert.ItemArray[38].ToString();
                        item.SpecificRequiredProvisions = entityToInsert.ItemArray[39].ToString();
                        item.GeneralRequiredProvisions = entityToInsert.ItemArray[40].ToString();
                        item.Reason = entityToInsert.ItemArray[41].ToString();
                        item.TranNo = 1;// entityToInsert.ItemArray[41].ToString();
                        item.RawFiles = "";
                        item.isConsolidated = true;
                        item.isDeleted = false;
                        item.UserName = "dong";
                        item.TransDate = DateTime.Now.ToString();
                        item.RecordDate = DateTime.Now.ToString(); //Convert.ToDateTime(entityToInsert.ItemArray[7]);
                        item.SYSTEM = "icbs";// entityToInsert.ItemArray[8].ToString();
                        ++count;
                        context = AddToContext(item, count, 100, true);
                    }

                    context.SaveChanges();
                    scope.Commit();//.Complete();
                }
                catch (Exception ex)
                {
                    scope.Rollback();
                    throw ex;
                }
                finally
                {
                    if (context != null)
                        context.Dispose();

                    context.Configuration.AutoDetectChangesEnabled = true;
                    context.Configuration.ValidateOnSaveEnabled = true;
                }

                // scope.Commit();//.Complete();
            }

        }


        private NTC_Context_Entities AddToContext(BDOLF_NTC_Consolidator entity, int count, int commitCount, bool recreateContext)
        {
            context.Set<BDOLF_NTC_Consolidator>().Add(entity);

            if (count % commitCount == 0)
            {
                context.SaveChanges();
                if (recreateContext)
                {
                    context.Dispose();
                    context = new NTC_Context_Entities();
                    context.Configuration.AutoDetectChangesEnabled = false;
                    context.Configuration.ValidateOnSaveEnabled = false;
                }
            }

            return context;
        }
