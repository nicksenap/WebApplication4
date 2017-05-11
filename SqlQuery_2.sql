﻿CREATE TABLE [dbo].[InvestAccounts] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [InvestCount] [int] NOT NULL,
    [Amount] [int] NOT NULL,
    CONSTRAINT [PK_dbo.InvestAccounts] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[InvestApplications] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [Amount] [int] NOT NULL,
    [Months] [int] NOT NULL,
    CONSTRAINT [PK_dbo.InvestApplications] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[LoanAccounts] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [Amount] [int] NOT NULL,
    [Months] [int] NOT NULL,
    [APR] [float] NOT NULL,
    [Risk] [int] NOT NULL,
    [User_Id] [nvarchar](128),
    CONSTRAINT [PK_dbo.LoanAccounts] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_User_Id] ON [dbo].[LoanAccounts]([User_Id])
CREATE TABLE [dbo].[Loans] (
    [Id] [int] NOT NULL IDENTITY,
    [Amount] [float] NOT NULL,
    [Month] [int] NOT NULL,
    [LoanAccount_Id] [int],
    CONSTRAINT [PK_dbo.Loans] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_LoanAccount_Id] ON [dbo].[Loans]([LoanAccount_Id])
CREATE TABLE [dbo].[LoanPayments] (
    [Id] [int] NOT NULL IDENTITY,
    [Amount] [float] NOT NULL,
    [CreationDate] [datetime] NOT NULL,
    [Loan_Id] [int],
    CONSTRAINT [PK_dbo.LoanPayments] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_Loan_Id] ON [dbo].[LoanPayments]([Loan_Id])
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] [nvarchar](128) NOT NULL,
    [PersoNunmber] [nvarchar](max),
    [CreationDate] [datetime] NOT NULL,
    [FirstName] [nvarchar](max),
    [LastName] [nvarchar](max),
    [Email] [nvarchar](256),
    [EmailConfirmed] [bit] NOT NULL,
    [PasswordHash] [nvarchar](max),
    [SecurityStamp] [nvarchar](max),
    [PhoneNumber] [nvarchar](max),
    [PhoneNumberConfirmed] [bit] NOT NULL,
    [TwoFactorEnabled] [bit] NOT NULL,
    [LockoutEndDateUtc] [datetime],
    [LockoutEnabled] [bit] NOT NULL,
    [AccessFailedCount] [int] NOT NULL,
    [UserName] [nvarchar](256) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY ([Id])
)
CREATE UNIQUE INDEX [UserNameIndex] ON [dbo].[AspNetUsers]([UserName])
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] [int] NOT NULL IDENTITY,
    [UserId] [nvarchar](128) NOT NULL,
    [ClaimType] [nvarchar](max),
    [ClaimValue] [nvarchar](max),
    CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]([UserId])
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] [nvarchar](128) NOT NULL,
    [ProviderKey] [nvarchar](128) NOT NULL,
    [UserId] [nvarchar](128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey], [UserId])
)
CREATE INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]([UserId])
CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId] [nvarchar](128) NOT NULL,
    [RoleId] [nvarchar](128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId])
)
CREATE INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]([UserId])
CREATE INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]([RoleId])
CREATE TABLE [dbo].[LoanApplications] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [Amount] [int] NOT NULL,
    [Months] [int] NOT NULL,
    [UCScore] [float] NOT NULL,
    [UCData] [nvarchar](max),
    [UCViews] [int] NOT NULL,
    [UCQueries] [int] NOT NULL,
    [APR] [float] NOT NULL,
    [DataScore] [nvarchar](max),
    [Flag] [int] NOT NULL,
    [AMLData] [nvarchar](max),
    CONSTRAINT [PK_dbo.LoanApplications] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] [nvarchar](128) NOT NULL,
    [Name] [nvarchar](256) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY ([Id])
)
CREATE UNIQUE INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]([Name])
CREATE TABLE [dbo].[UserChangeLogs] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [TableName] [nvarchar](max),
    [ColumnName] [nvarchar](max),
    [RowID] [int] NOT NULL,
    [OriginalValue] [nvarchar](max),
    [ChangeValue] [nvarchar](max),
    [Editor] [nvarchar](max),
    [IPNumber] [nvarchar](max),
    [User_Id] [nvarchar](128),
    CONSTRAINT [PK_dbo.UserChangeLogs] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_User_Id] ON [dbo].[UserChangeLogs]([User_Id])
CREATE TABLE [dbo].[UserInfoDatas] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [Status] [int] NOT NULL,
    [Data] [nvarchar](max),
    [P2PUser_Id] [nvarchar](128),
    [UserInfoType_Id] [int],
    CONSTRAINT [PK_dbo.UserInfoDatas] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_P2PUser_Id] ON [dbo].[UserInfoDatas]([P2PUser_Id])
CREATE INDEX [IX_UserInfoType_Id] ON [dbo].[UserInfoDatas]([UserInfoType_Id])
CREATE TABLE [dbo].[UserInfoTypes] (
    [Id] [int] NOT NULL IDENTITY,
    [CreationDate] [datetime] NOT NULL,
    [Status] [int] NOT NULL,
    [Name] [nvarchar](max),
    CONSTRAINT [PK_dbo.UserInfoTypes] PRIMARY KEY ([Id])
)
ALTER TABLE [dbo].[LoanAccounts] ADD CONSTRAINT [FK_dbo.LoanAccounts_dbo.AspNetUsers_User_Id] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[AspNetUsers] ([Id])
ALTER TABLE [dbo].[Loans] ADD CONSTRAINT [FK_dbo.Loans_dbo.LoanAccounts_LoanAccount_Id] FOREIGN KEY ([LoanAccount_Id]) REFERENCES [dbo].[LoanAccounts] ([Id])
ALTER TABLE [dbo].[LoanPayments] ADD CONSTRAINT [FK_dbo.LoanPayments_dbo.Loans_Loan_Id] FOREIGN KEY ([Loan_Id]) REFERENCES [dbo].[Loans] ([Id])
ALTER TABLE [dbo].[AspNetUserClaims] ADD CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserLogins] ADD CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserRoles] ADD CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[AspNetUserRoles] ADD CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE
ALTER TABLE [dbo].[UserChangeLogs] ADD CONSTRAINT [FK_dbo.UserChangeLogs_dbo.AspNetUsers_User_Id] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[AspNetUsers] ([Id])
ALTER TABLE [dbo].[UserInfoDatas] ADD CONSTRAINT [FK_dbo.UserInfoDatas_dbo.AspNetUsers_P2PUser_Id] FOREIGN KEY ([P2PUser_Id]) REFERENCES [dbo].[AspNetUsers] ([Id])
ALTER TABLE [dbo].[UserInfoDatas] ADD CONSTRAINT [FK_dbo.UserInfoDatas_dbo.UserInfoTypes_UserInfoType_Id] FOREIGN KEY ([UserInfoType_Id]) REFERENCES [dbo].[UserInfoTypes] ([Id])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201705091233383_first', N'WebApplication4.Migrations.Configuration',  0x1F8B0800000000000400ED5D5973E4B6117E4F55FE036B9E9294ACD161BB1C9564973C5A39AAE88A46EB244F2A6A088D58CB634C7276A54AE597E5213F297F21004FDC044090C3B1A7F66147381ADD8D0F57138DFEDF7FFE7BFAC35B18389F4192FA71743639DC3F9838205AC49E1F2DCF26EBECE5ABEF263F7CFFFBDF9D7EF0C237E7E7AADC312A076B46E9D9E435CB5627D369BA7805A19BEE87FE2289D3F825DB5FC4E1D4F5E2E9D1C1C19FA787875300494C202DC7397D5847991F82FC0FF8E72C8E166095ADDDE026F6409096E930679E53756EDD10A42B7701CE267F07CFE7AB55E02FDC0CB2F2F5FEC5F9F5C4390F7C17B23207C1CBC471A328CEF2DC938F299867491C2DE72B98E0068FEF2B00CBBDB8410A4A014E9AE2AAB21C1C2159A64DC58AD4629D6671A849F0F0B854CE94AE6EA4E249AD3CA8BE0F50CDD93B923A57E1D9E42AFA0CD2EC7CB188610F4C1CBAC5935990A0D25C35EF1395F71CAAC85E0D0F8822F46FCF99AD836C9D80B308ACB3C40DF69CFBF5332CFF57F0FE187F02D159B40E029C5FC831CC231260D27D12AF4092BD3F80974A0A6FE24CC97A53BA625D0DAB5388761565C74713E71636EE3E07A08603A686791627E0271081C4CD8077EF661948224403E40A655AA7DA9A2520A773016B57ADA2DF8F10F39C86E5C40AADCF8A0E934B2027741EEAD2389D36005281558306436835C93B780D042F7D54B0346EE2287B4D7B41D675EC4686D315567587A65F359A387CDC3FD4B2C4B01FF52579F0D34F9A3CDCBA9FFD65AE4B8A16422214E80104796EFAEAAF8ACD0A8ED1A7B2D46512870F714062BFC87C9AC7EB64817A29169578749325C8D459833BA4A495B3A2109F319427E52B2FC0634B6B0E3019FCBB51AF3A500DC7483E526D0E927BF73D84FC8BC7CA13598A842491C9C52459A233284B4A26D82CABEE20DA33443BAC6ECA50B83FBA2F66483D1894D5B61702F068ED47CB8973E3BE5D836899BD9E4D0E8FBE83A3D27F035E95522AF663E42FE0D9FE6C92256BFD5EBC870A896FD751F88CD42C6C1DFE546A7DC00DD1A59FA419FAD93BDBD7EE400D7D085D3F90B472F4CDB7B65A99C5D18B9F84A086DC8F319CCBD16E4017406E9A7E8913EF2F6EFADABB82E660B14EE01431CFDC70D57B6BF7AF71046ED7830C0DAC2D6B5DF3F825BE741770A9F810A15A9DE95DC78B4FF13AFB107968D07ECC16EC18562460851DB80D06697A09C10C3C0B461CB462B48C72D5F167BC539B05AE1FF2F768E59AF65415693668640EB33BA3B2758F31D7F1D2171CB12ACA551196A52247C85299ADCB122222E7A82CC132946708F929723B6D5EAB2D18A2976B5CB677B9A9CDCDE7E9EA1664FB55EDFD82EE650269C2C9F5D33E4376CF51AEDCEC7A8E54773DC787CF2FC7DF7DF3ADEB1D7FFB3538FEE6D7B80946AADCC48E2BEF3ED468FFDB2DD4D2CF6EB0B6DD94D168C807BBFDD190931DFF68C8D984C99F7D0FED26A6ED35AAC290BC52F90ACFBA638EE26CF003082EE6D08D0F3307180D17B416D91F2D88EAF8070B1FCADCA2482013D46F6AF6AFF81D09E27273B2F9C745AAFAF61A5C761F83CCCE4CB3F9026AA5A325F1E30C2AC2ED7D3BF471F6B30FBE7496F86F6B90F860E35FD190CA08E5F7A6B7CBC05DD68DA0531684B2E76745B2AEDC37D73DF4B5F6026B7F71DD8E85755BACD29BB6C3A0DD01DFC280F7F75359AC3133B0B98CAD8153A493C121B708BCBAD112C08DBCEEFA4D54DEADDEE2B6ACAEDE8FA8EC201F146671B00EA3419A7A88BF5C5D745B14EF121F1E45DDA00F9305473739EE8769EB035C2FE3FE3F225CDDF7F5B542FF960B31B530F75CD85C66A2E414E93C515E452F71B1FFD09F27ABBABB6972A069720E795AA7C4CE13EF872ADB60DF3CE0F8A86F3008864825CD535D901C24743E779830854CEEAA212285595AC22A2AF054A890E5B3CEACDBA7996C4A5462741ACA05BB66431995D80DE5CD0F6594643894FBD9D708074901FBEE83433482D9E1A33638D6213634F0B3F9558AFE6FBC72F4064A43C9DA30819AF74012BCC39EC2614CEAFF06A02D4C29CE8F81BBF83471F25DDAD9E480E92CA2F003BA5350163D9417FD270882F84B5DFA485EFA2E41DB90BAF4B1BCF44F0900515DF86BB61B8B0E9374226F99EBD6992CC5BE3B95945A20203EF8ED08D8501C56C0F3348D177EDE10665A272FD59298F910794EEB0DDB66BE2CAE6ADF40867D24129C09E078D8DF67712EA35BAFCB24DDFAB62D49FE4F34743121DB65272FDFCB7814DCC42779AC5D55B455C0BFC6DFA25A73D9A98B3A22CE44B7761AB6EA1D21C9D9E184DE5CDC451720001970CE17856FE4CC4D17AEC72E6D70EEF114F9E1A88973B545AA33481E6E7740826AB9E8C2610AC7981F65ECDEC88F16FECA0DA49AA16A29EEA990D0357D3AE702AC40848492AA40A561E107CB69DD06D5136D9A31005C790DABAD83E93B599B061C75094C00B8F2F648AF8023353320E048156C0DE08A5B766DFD4B5DB9DB34DCC83B7E02B415DF877A051BA19601B146C83F7AA831BE722A0B3D692751DA46B09D2B21CD018F00CBECEE444376CEA726118BB2EF4E2CC279E8EE69D449BE760D3FF4C45A1A60FC8935A1D238FF9AD340839063CA17F5B7CCAE4FDA7EB06F96EA4351F24DA0E7C1C8B5D5CAD8141B6EF9E66C5D35086DBE0329A23176B571C9B17CF1CD809A673B89D9D948C54225148637388A3238866A330F54EEC5334A046F3C3F55D87069B0484B43232D07223A075935BDE04FC0A413A7B1F6559324F9C00CA3162EB9C6FC212189DFFF6B218BAD853C82C40AAB404A4443A972E3ACCCA5511B355A48959738181AF5E069D3347D2CE66A9A3D3B6B90AD1C6CA464CB139206D9D24B464AB5588E555021871A73D1B485641B6F4A7C11CB058F1AB5102990ABE61211B566AE512496CF101262C5C44811C3262AB217282F7EAC9CD0D59FDE51A8D8256B61EA61CC6C4C54CC901499866F7A8749CAABA80BEAF50FBE2E24564A453B252544333BB6A8846F966CD3AC812E68CF4156113293A58AD11263BA9C4D25B20B0C8D180DDE8C6A4D0BD55C2AD602CF8EA6624933D20265FD1268A162DA9A16CAE955AC048E6D47C1BA63A402D22223D040C9B0D589A158DEE5F302BBCF57333B749D15882D7D9B5A0DF4C0BBC7CA6AA2CD04A16A84C004E076A4AACDA06770F0EEACB14A693B0EAB1E88A95EC5372A12ED488EC03DC0847F4589AF13F9F158FD804C8981EDB85AD4223C12F7A818ECCE87582B82B3B2E26999A38F72D3A8A00FF670ACAA5E8952AABB28F591B8CE3B9D16EFCA9609A753C103B4A737EE6AE5474BEC41DA32C59917AFD1CEBE9AEBBFD21A1634A60B629EA20FF0754B599CB84B40E5A25BD31EC85F97417A7976D16584991732C508038060B35F35C53DE3B3BD579D01AA6AE87751B5F5D5588E19B1A472098544FBEA5C5E804FA1F2FA0E7A24D80DDC84730BADB958CE378C8A6B93F7CA703A648E3A45E2195782313C439D5EE55C8793AAD2582AA7534ACD8C8596E956C67C4E8245074AF8A1DB129CB043BA31A46434B605567A301051A9BC2C712A55DA68C044EC50BBC208B701EA03485A7B071D317484BC204F53821194A05EBF78AD152750A48C0ABC76506B08D7A1706A11551C508DAC4725E649FD8EAD3E0598F5AFB0F698BBD97C52DB50A78BAC0B7ABD2D387A2AF4B4B0663FBD4CBEBB89D3217336B98C612F6CE2E4B064755ACD1B9A38A926559D52F948264EA64CD2A481BDB3C810C3F234FA94780A93E85322479D22F5DE254E92CAD2E0127FD5926012CF30A227D028BF847A0BEC3B96387536570395EC8B96043CD96C03DA1C9EE93C8DD5817DF4925828D86C75DA68FE63C768933A9AB582F381A8F3E197F9406F70F86DA7D1CF62525DD1A4BB4DF31CD43C4C48AC1E4DB226ADD2B79E2156A68F124EC28F7FE6702A2E66748393808678EE21DEF423A71EE94384629AC4437DC4F42E7BA8504C4F0FB4238086E893A83932F24B2CDD80C127D1EF44515D46258C02820BAA9BB569D9348FD237980C6D5B3BD3A85DFB56FD041D81E92A51874EF1158F24C3BBCA25A752BE314792291375E8D4CFCC9194EAE4E12C80D84B7338152C59E348993BA613A7C93C45439AEA053942A22A7134D38FDDC5A2E342A1B748749B6DD803C4C80E0FD45D8BAE5D445E21D5EFA396FADBB224606F9A1187F32659833BECD53282372C5D67B7923F4C466E56F224751AD4CB64382D2A4B434AFCFD31424C3C43C3A655BE3146D8B2CA348D8FE9F73CD350933AAA61DCDC5DB1318AEBABDB6683585C7D5BC670F5120761662CD3F4B60BEC4E6184C8292E51D9424E6E2131470EBFFA6F0B39E3D93A9037DFD88325E566D17E70A42A687C664477FA18EB8EC02F83D593127A727A7CEF52AC7113BE841EAEC6A896B2348B23B8E0215FC5AB14BD2556BF25A4202D7DDDD1081794CB89F24599AA82CAF50281E2B9CE291D0051D1B3840BAEB7CBE8702116DA2A3C8A5BD4EAE828CA6B5C956AE904FC72B4611FE4242C6303BF053E2A680884ED8C099EBF81C66953800BE98992D305628F820D6343EC3BF19B4107EB7BA17E8E69EAE81C5704FD20F2AD30EC898A8A2594887C49468513B1CCD6A08279A3A89F5ACA0A9640C2F8AF7498446A7A1661C238C48C0A232D52B7038571CDA18BD447A732A5FEBB76CD29DD62087F9D5C2BC8FB26D7465ABAE8D07E32459189537D118687C0F73403E13E2AB03FFF2598053E3AE2D4056EDCC87F016956BCB639393A383C9A38E781EFA6850755E9017442BFAEA1E41274788C5C8280174EE9EAFA8E45884A9A7AC44BCF9CF03262879A211E85F6916A5B9F7DB610E6DD83BF339377A0098F1C8CE94EE1AFDA29A8C70792BBAFEC3AD144FB2C0532F498C5FE131E89763DB7999EE3F0D0443E7B0962579F40E17E62CE40BD072B48449FDD64F1EA269C279CAE220FBC9D4DFE95573C71AEFEF154D6DD73EE12B87A9D3807CEBFD970580D3F1D2295B1969FAD8530893AB34E2F5D54CC7B9DB6EE609414FA9DAC4D76BFB5EEE61A807FD3BD6E75F2ABEDBEFA5DDF4F9FF35F111CA0BF9B294F3C75A9C56E265C5548E27F08DDB73FCA35D57387637E2A16586B5C552C102B1D5624DD91873834208A395814D49F7DFD7147BAAB5890977256B140917056B14BCF8A0A59AF14735A1C3714F1D050C232E57E62CE1AC7DFA4DBCE8C37C4DAE7E9AA669EBCE75CA51F23FF9735CC7884DAA0F668D4C8B215AF9DE3F0B1B56B777525DC7087ACBE4156DB05340E28369618CC03459B9C113238BE1B6AC86871D5E0D490BA6228BFEDDE8E3F8A33DBDB0A5C0ACBB437096D23F4B07777D5C02372EB507E5CBC1D05E39A262A290CB829AA0ED1B3521790AD5D2F7E7546AADA7FA4CBE9B5F21EB1B068D51E245D44AA5D473668BCC39C462CA8A5F01DE9204EE536D2FF46C0741A1FC949DF6C5B8E84DEC0B65C72016637C5E687533A007DB71D351364BE13392290BCC9A8E68691EF26211B2ABE9BF9870807DF89141DF2BDDB32B3159F46C4175376A33B37B611C1964D4690B57D0B7EE5C900534D757358098E2DF81D1BBD0F0254F51E3E0C887D427600B70370C3C54AD4835D83FFDA08F45B87BBA148A9C5F6750C43AA099E4D54C1A4A3133D4DFE8A1FCF7426746919386AA172F8638B118F75A31B77E97DF153AFBD8040B9F7E5FE2B034649558B03BDC1C8A89CD854182F03477D1E3214A3ECAD2F0D83EAF8623C8F044C65443201980688E83C3498442F7D8D144C4AF19B4782A522DE9B004AFD876B1E1A4982075F460624E5E8CC1A5852D8DE686E98B60F09BAFB2A892BD50028308C533D96D0D49B9C5D5ADE771AC714B32DB1A7ED4D32E407840E91ABC73ED1B43D5E35B6A986EBDE3A0C1E9AC0AE141CD403786F031A248F2071AE1B49BD7807C4436E8B550E466E3B00F92660D1F2ECD0E6B1A1E0BF6B1D2094EB6BFD7D920EE7467768E9F35C698A0CB4DE987CF981D80BA7D7B389F71C431014A6633A983B03216E8B78786C51AB781949CB4430EE96D689AD33D32E91CB6B5116DE94DB9630E6BB88BA1AD9DAD0CDA55EE78A1A11069FA6DBAA9710A69DE6BD054E1BE7E9EA1664C5F6B8150FACCD8DC5035B46DEAC2092B2ACEDD244236DBB2C236F5B10BF58D676B1EB96365D1491B7CC0F0DCB1D02D2E1C794100E059DA1471E7B84C2B609AA2624B577655AA3F279CD1145D45A6CD6416E834DB6A83D7180525173C5522E6CAEC89635874AB0CD09E349538FBBF1034A4BBE0632060E267C3467F5147CFDA32AD6E9F4C1B853E0EC72529647CE16C565E35A7228B6EBF416B15B15D521447A355F8A63A40B438F3027108CCB3A4D229A70FE178419B1277435518B851606C8B02934B1F0088261D813BA9C3EC5328B1EF3B62932BE04F0A33CD81DC30573F221CC3B785A10DB60E48F2FC23DB7AF78FDB4D11EE798CFBA46B437ED75EEF683F3609D1DA17B085ADF45707A17C4BEB0654FECC618623124BD300CFDA0A26B049E675FB13A9D3EC099C50F8BAB5BA71720F5970D09F43E5704168449A12E8358AD4C1C14475511DA070564AE07853B4F32FFC55D64301B79CAFA1104787E9118F96B3F03EF2ABA5B67AB75064506E17340B8ED210B89ACFDD329C3F3E9DD2A3F79D81001B2E9A33B7A77D18F6B3FF06ABE2F3957F3052490E9A5BC4588FA3243B70997EF35A5DB38522454AAAFB6183D8270154062E95D34773F0313DE2004AFC1D25DBC377E8C2222ED1D41AAFDF4C27797891BA6258DA63EFC1362D80BDFBEFF3F39A1B95423D80000 , N'6.1.3-40302')
