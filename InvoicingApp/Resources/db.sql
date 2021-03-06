USE [tc_invoicing]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_company]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_company](
	[company_code] [varchar](50) NOT NULL,
	[company_name] [varchar](50) NULL,
	[company_registered_address] [varchar](100) NULL,
	[company_rel_address] [varchar](100) NULL,
	[company_storage_address] [varchar](100) NULL,
	[company_artificial_person] [varchar](50) NULL,
	[company_principal] [varchar](50) NULL,
	[company_business_type] [varchar](50) NULL,
	[company_style] [varchar](50) NULL,
	[company_licence] [varchar](50) NULL,
	[company_business_licence] [varchar](50) NULL,
	[company_tel] [varchar](50) NULL,
	[company_mobile] [varchar](50) NULL,
	[company_fax] [varchar](50) NULL,
	[company_postal_code] [varchar](50) NULL,
	[company_bank] [varchar](50) NULL,
	[company_bank_num] [varchar](50) NULL,
	[company_tariff_num] [varchar](50) NULL,
	[company_quality_persion] [varchar](50) NULL,
	[company_business_scope] [varchar](5000) NULL,
 CONSTRAINT [PK_TC_COMPANY] PRIMARY KEY NONCLUSTERED 
(
	[company_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_staff]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_staff](
	[staff_code] [varchar](20) NOT NULL,
	[staff_name] [varchar](50) NULL,
	[staff_yxm] [varchar](50) NULL,
	[staff_sex] [varchar](10) NULL,
	[staff_birthday] [datetime] NULL,
	[staff_card] [varchar](50) NULL,
	[staff_tel] [varchar](50) NULL,
	[staff_edu] [varchar](50) NULL,
	[staff_introduction] [varchar](5000) NULL,
	[staff_dep] [varchar](50) NULL,
	[staff_contract_num] [varchar](50) NULL,
	[staff_job_title] [varchar](50) NULL,
	[staff_specialities] [varchar](50) NULL,
 CONSTRAINT [PK_TC_STAFF] PRIMARY KEY NONCLUSTERED 
(
	[staff_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_storage_details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_storage_details](
	[storage_code] [varchar](20) NOT NULL,
	[storage_input_code] [varchar](20) NULL,
	[storage_goods_code] [varchar](20) NULL,
	[storage_count] [numeric](5, 0) NULL,
	[storage_inputdate] [datetime] NULL,
	[storage_maker_code] [varchar](20) NULL,
	[storage_count_name] [varchar](50) NULL,
 CONSTRAINT [PK_TC_STORAGE_DETAILS] PRIMARY KEY NONCLUSTERED 
(
	[storage_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_supplier]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_supplier](
	[supplier_code] [varchar](20) NOT NULL,
	[supplier_name] [varchar](50) NULL,
	[supplier_yxm] [varchar](50) NULL,
	[supplier_address] [varchar](100) NULL,
	[supplier_artificial_person] [varchar](50) NULL,
	[supplier_business_scpoe] [varchar](100) NULL,
	[supplier_licence] [varchar](50) NULL,
	[supplier_trustpersion] [varchar](50) NULL,
	[supplier_tariff_num] [varchar](50) NULL,
	[supplier_principal] [varchar](50) NULL,
	[supplier_bank] [varchar](50) NULL,
	[supplier_bank_num] [varchar](50) NULL,
	[supplier_tel] [varchar](50) NULL,
	[supplier_fax] [varchar](50) NULL,
	[supplier_business_licence] [varchar](50) NULL,
	[supplier_postal_code] [varchar](50) NULL,
	[supplier_make_quality_num] [varchar](50) NULL,
	[supplier_business_num] [varchar](50) NULL,
	[supplier_type] [varchar](50) NULL,
 CONSTRAINT [PK_TC_SUPPLIER] PRIMARY KEY NONCLUSTERED 
(
	[supplier_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_maker]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_maker](
	[maker_code] [varchar](20) NOT NULL,
	[maker_name] [varchar](50) NULL,
	[maker_yxm] [varchar](50) NULL,
	[maker_address] [varchar](100) NULL,
	[maker_quality_reg] [varchar](50) NULL,
	[maker_hygiene] [varchar](50) NULL,
	[maker_licence] [varchar](50) NULL,
	[maker_tel] [varchar](50) NULL,
	[maker_principal] [varchar](50) NULL,
	[maker_postal_code] [varchar](50) NULL,
	[maker_business_scope] [varchar](100) NULL,
	[maker_business_goods] [varchar](100) NULL,
 CONSTRAINT [PK_TC_MAKER] PRIMARY KEY NONCLUSTERED 
(
	[maker_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_input_storage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_input_storage](
	[input_code] [varchar](20) NOT NULL,
	[input_goods_code] [varchar](20) NULL,
	[input_quality_reg] [varchar](50) NULL,
	[input_batch_num] [varchar](50) NULL,
	[input_arrival_count] [int] NULL,
	[input_standard_count] [int] NULL,
	[counter_name] [varchar](50) NULL,
	[supplier_name] [varchar](50) NULL,
	[input_check_persion] [varchar](50) NULL,
	[input_oper] [varchar](50) NULL,
	[input_quality_persion] [varchar](50) NULL,
	[input_issued] [varchar](50) NULL,
	[input_packing_in] [varchar](20) NULL,
	[input_packing_mid] [varchar](20) NULL,
	[input_packing_out] [varchar](20) NULL,
	[input_remark] [varchar](500) NULL,
	[input_instorage_date] [datetime] NULL,
	[input_maketime] [datetime] NULL,
	[input_checktime] [datetime] NULL,
	[input_type] [varchar](1) NULL,
	[operate_type] [varchar](1) NULL,
	[backstorage_date] [datetime] NULL,
	[output_code] [varchar](20) NULL,
	[quality_info] [varchar](500) NULL,
	[check_info] [varchar](500) NULL,
 CONSTRAINT [PK_TC_INPUT_STORAGE] PRIMARY KEY NONCLUSTERED 
(
	[input_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_temp_storage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_temp_storage](
	[goods_code] [varchar](20) NOT NULL,
	[count] [int] NULL,
 CONSTRAINT [PK_tc_temp_storage] PRIMARY KEY CLUSTERED 
(
	[goods_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_unit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_unit](
	[unit_code] [varchar](20) NOT NULL,
	[unit_name] [varchar](50) NULL,
	[unit_yxm] [varchar](50) NULL,
 CONSTRAINT [PK_TC_UNIT] PRIMARY KEY NONCLUSTERED 
(
	[unit_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_lose]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_lose](
	[lose_code] [varchar](20) NOT NULL,
	[input_code] [varchar](200) NULL,
	[lose_count] [int] NOT NULL CONSTRAINT [DF_tc_lose_lose_count]  DEFAULT ((0)),
	[lose_reason] [varchar](200) NULL,
	[lose_applier] [varchar](200) NULL,
	[lose_checker] [varchar](200) NULL,
	[lose_datetime] [datetime] NULL,
	[lose_result] [varchar](200) NULL,
	[lose_remark] [varchar](200) NULL,
 CONSTRAINT [PK_TC_LOSE] PRIMARY KEY NONCLUSTERED 
(
	[lose_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_maintain]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_maintain](
	[maintain_code] [varchar](20) NOT NULL,
	[maintain_input_code] [varchar](50) NULL,
	[maintain_application] [varchar](500) NULL,
	[maintain_purpose] [varchar](500) NULL,
	[maintain_quality] [varchar](500) NULL,
	[maintain_test_items] [varchar](500) NULL,
	[maintain_characters] [varchar](500) NULL,
	[maintain_create_date] [datetime] NULL,
 CONSTRAINT [PK_TC_MAINTAIN] PRIMARY KEY NONCLUSTERED 
(
	[maintain_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_maintain_detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_maintain_detail](
	[maintain_detail_code] [int] IDENTITY(1,1) NOT NULL,
	[maintain_detail_datetime] [datetime] NULL,
	[maintain_detail_quality] [varchar](500) NULL,
	[maintain_detail_settle] [varchar](500) NULL,
	[maintain_detail_oper] [varchar](50) NULL,
	[maintain_detail_remark] [varchar](500) NULL,
	[maintain_code] [varchar](20) NULL,
 CONSTRAINT [PK_tc_maintain_detail] PRIMARY KEY CLUSTERED 
(
	[maintain_detail_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_output_storage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_output_storage](
	[output_code] [varchar](20) NOT NULL,
	[input_code] [varchar](20) NULL,
	[customer_code] [varchar](20) NOT NULL,
	[output_count] [int] NULL,
	[output_check_persion] [varchar](50) NULL,
	[output_oper] [varchar](50) NULL,
	[output_quality_persion] [varchar](50) NULL,
	[output_issued] [varchar](50) NULL,
	[output_packing_in] [varchar](50) NULL,
	[output_packing_mid] [varchar](50) NULL,
	[output_packing_out] [varchar](50) NULL,
	[output_remark] [varchar](500) NULL,
	[output_instorage_date] [datetime] NULL,
	[output_checktime] [datetime] NULL,
	[output_type] [varchar](1) NULL,
	[output_backreason] [varchar](500) NULL,
	[operate_type] [varchar](1) NULL,
 CONSTRAINT [PK_TC_OUTPUT_STORAGE] PRIMARY KEY NONCLUSTERED 
(
	[output_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_apparatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_apparatus](
	[apparatus_code] [varchar](50) NOT NULL,
	[apparatus_name] [varchar](50) NULL,
	[apparatus_yxm] [varchar](50) NULL,
	[apparatus_upcode] [varchar](20) NULL,
	[apparatus_type] [varchar](50) NULL,
	[apparatus_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tc_apparatus_1] PRIMARY KEY CLUSTERED 
(
	[apparatus_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_system_log]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_system_log](
	[systemlog_code] [int] IDENTITY(1,1) NOT NULL,
	[systemlog_logon] [datetime] NULL,
	[systemlog_logoff] [datetime] NULL,
	[systemlog_user] [varchar](20) NULL,
 CONSTRAINT [PK_TC_SYSTEM_LOG] PRIMARY KEY NONCLUSTERED 
(
	[systemlog_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_disqualification_manage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_disqualification_manage](
	[disqualification_code] [int] IDENTITY(1,1) NOT NULL,
	[input_code] [varchar](20) NULL,
	[deal_count] [int] NULL,
	[undeal_count] [int] NULL,
	[disqualification_count] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_disqualification_To]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_disqualification_To](
	[disqualification_to_code] [int] IDENTITY(1,1) NOT NULL,
	[disqualification_code] [int] NULL,
	[disqualification_to_count] [int] NULL,
	[deal_type] [varchar](1) NULL,
	[deal_date] [datetime] NULL,
	[deal_address] [varchar](100) NULL,
	[issued] [varchar](20) NULL,
	[reamark] [varchar](500) NULL,
	[deal_oper] [varchar](500) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_code_seq]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_code_seq](
	[code] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK_tc_code_seq] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_counter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_counter](
	[counter_code] [varchar](50) NOT NULL,
	[counter_manager] [varchar](50) NULL,
	[counter_type] [varchar](50) NULL,
 CONSTRAINT [PK_TC_COUNTER] PRIMARY KEY NONCLUSTERED 
(
	[counter_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_authority]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_authority](
	[authority_id] [int] IDENTITY(1,1) NOT NULL,
	[authority_user_code] [varchar](50) NOT NULL,
	[authority_password] [varchar](50) NULL,
	[authority_level] [varchar](1) NULL,
	[staff_code] [varchar](20) NULL,
 CONSTRAINT [PK_tc_authority] PRIMARY KEY CLUSTERED 
(
	[authority_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_device]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_device](
	[device_id] [int] IDENTITY(1,1) NOT NULL,
	[device_code] [varchar](20) NULL,
	[device_name] [varchar](50) NULL,
	[device_type] [varchar](20) NULL,
	[device_made] [varchar](50) NULL,
	[device_date] [datetime] NULL,
	[device_usedate] [datetime] NULL,
	[device_address] [varchar](50) NULL,
	[device_application] [varchar](100) NULL,
	[staff_name] [varchar](20) NULL,
	[device_remarks] [varchar](100) NULL,
 CONSTRAINT [PK_tc_device] PRIMARY KEY CLUSTERED 
(
	[device_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_archives]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_archives](
	[archives_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_usecode] [varchar](50) NOT NULL,
	[customer_code] [varchar](20) NOT NULL,
	[customer_sex] [varchar](5) NULL,
	[customer_age] [varchar](3) NULL,
 CONSTRAINT [PK_tc_archives] PRIMARY KEY CLUSTERED 
(
	[archives_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_visit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_visit](
	[visit_id] [int] IDENTITY(1,1) NOT NULL,
	[visit_output_code] [varchar](20) NULL,
	[visit_date] [datetime] NULL,
	[staff_name] [varchar](20) NULL,
	[visit_man] [varchar](20) NULL,
	[visit_usage] [varchar](50) NULL,
	[visit_opinion] [varchar](50) NULL,
	[visit_remarks] [varchar](100) NULL,
 CONSTRAINT [PK_tc_visit] PRIMARY KEY CLUSTERED 
(
	[visit_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_goods]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_goods](
	[goods_code] [varchar](20) NOT NULL,
	[goods_name] [varchar](50) NULL,
	[goods_yxm] [varchar](50) NULL,
	[goods_reg_num] [varchar](50) NULL,
	[goods_reg_mark] [varchar](50) NULL,
	[goods_type] [varchar](50) NULL,
	[goods_maker] [varchar](50) NULL,
	[goods_validity] [int] NULL,
	[goods_unit] [varchar](20) NULL,
	[goods_storemethod] [varchar](500) NULL,
	[goods_appliance_code] [varchar](50) NULL,
	[goods_batch_num] [varchar](50) NULL,
 CONSTRAINT [PK_TC_GOODS] PRIMARY KEY NONCLUSTERED 
(
	[goods_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_customer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_customer](
	[customer_code] [varchar](20) NOT NULL,
	[customer_name] [varchar](50) NULL,
	[customer_yxm] [varchar](50) NULL,
	[customer_artificial_person] [varchar](50) NULL,
	[customer_bank] [varchar](50) NULL,
	[customer_bank_num] [varchar](50) NULL,
	[customer_address] [varchar](100) NULL,
	[customer_principal] [varchar](50) NULL,
	[customer_tariff_num] [varchar](50) NULL,
	[customer_licence] [varchar](50) NULL,
	[customer_business_licence] [varchar](50) NULL,
	[customer_type] [varchar](50) NULL,
	[customer_tel] [varchar](50) NULL,
	[customer_fax] [varchar](50) NULL,
	[customer_postal_code] [varchar](50) NULL,
	[customer_medical_institutions] [varchar](50) NULL,
	[customer_quality] [varchar](50) NULL,
	[customer_flag] [varchar](1) NULL,
 CONSTRAINT [PK_TC_CUSTOMER] PRIMARY KEY NONCLUSTERED 
(
	[customer_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_apparatus_quality]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_apparatus_quality](
	[apparatus_quality_code] [varchar](20) NOT NULL,
	[apparatus_output_code] [varchar](20) NULL,
	[apparatus_quality_count] [int] NULL,
	[apparatus_qualityt_issued] [varchar](50) NULL,
	[apparatus_accident_conditions] [varchar](500) NULL,
	[apparatus_report_date] [datetime] NULL,
	[apparatus_accident_management] [varchar](500) NULL,
	[apparatus_accident_management_date] [datetime] NOT NULL,
	[Apparatus_speaker] [varchar](50) NULL,
	[apparatus_customer_feedback] [varchar](500) NULL,
	[apparatus_opinion_leader] [varchar](500) NULL,
 CONSTRAINT [PK_TC_APPARATUS_QUALITY] PRIMARY KEY NONCLUSTERED 
(
	[apparatus_quality_code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tc_upload_log]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tc_upload_log](
	[upload_id] [int] IDENTITY(1,1) NOT NULL,
	[upload_date] [datetime] NULL,
	[upload_result] [varchar](8) NULL,
	[upload_ip] [varchar](15) NULL,
 CONSTRAINT [PK_tc_upload_log] PRIMARY KEY CLUSTERED 
(
	[upload_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF