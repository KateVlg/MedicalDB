using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDB.DBWork
{
    static class Queries
    {
        #region select all
        public static string CreaturesTypesSelectAll => "select * from [dbo].[CreatureType]";
        public static string AnalysisTypesSelectAll => "select * from [dbo].[AnalysisType]";
        public static string ExaminationsTypesSelectAll => "select * from [dbo].[ExaminationType]";
        public static string MedicalFieldsSelectAll => "select * from [dbo].[MedicalField]";
        public static string ClinicsSelectAll => "select * from [dbo].[Clinic]";
        public static string MedicinesSelectAll => "select * from [dbo].[Medicines]";
        public static string FamilyMemberSelect => "select * from [dbo].[FamilyMember] order by FullName";
        public static string VisitSelect => "select v.DateAndTime, v.IdContract,v.IdFamilyMember,v.IdVisit,cast( v.Summ as float)Summ from [dbo].[VisitingMedicalFacility] v order by DateAndTime";
        public static string ContractSelect => "select cn.*, d.FullName, cl.[Name] from[Contract] cn join[dbo].[Doctor] d on cn.IdDoctor = d.IdDoctor join[dbo].[Clinic] cl on cn.IdClinic = cl.IdClinic";
        #endregion

        #region delete
        public static string CreaturesTypesDelete => "delete from [dbo].[CreatureType] where [IdCreatureType]= @id";
        public static string AnalysisTypesDelete => "delete from [dbo].[AnalysisType] where [IdAnalysisType]= @id";
        public static string ExaminationsTypesDelete => "delete from [dbo].[ExaminationType] where [IdExaminationType]= @id";
        public static string MedicalFieldsDelete => "delete from [dbo].[MedicalField] where [IdMedicalField]= @id";
        public static string ClinicsDelete => "delete from [dbo].[Clinic] where [IdClinic]= @id";
        public static string MedicinesDelete => "delete from [dbo].[Medicines] where [IdMedicines]= @id";
        public static string FamilyMemberDelete => "delete from [dbo].[FamilyMember] where [IdFamilyMember]= @id";
        public static string VisitDelete => "delete from [dbo].[VisitingMedicalFacility] where [IdVisit]= @id";
        #endregion

        #region update
        public static string CreaturesTypesUpdate => "update [dbo].[CreatureType] set name = @name where [IdCreatureType]= @id";
        public static string AnalysisTypesUpdate => "update [dbo].[AnalysisType] set name = @name where [IdAnalysisType]= @id";
        public static string ClinicsUpdate => "update [dbo].[Clinic] set name = @name, phone = @phone, address =@address where [IdClinic]= @id";
        public static string ExaminationTypesUpdate => "update [dbo].[ExaminationType] set name = @name where [IdExaminationType]= @id";
        public static string MedicalFieldsUpdate => "update [dbo].[MedicalField] set name = @name where [IdMedicalField]= @id";
        public static string MedicinesUpdate => "update [dbo].[Medicines] set name = @name, cost=@cost, InstructionsForUse=@InstructionsForUse where [IdMedicines]= @id";
        public static string FamilyMemberUpdate => "update [dbo].[FamilyMember] set FullName = @fullName, DateOfBirth=@dateOfBirth, IdCreatureType=@IdCreatureType where [IdFamilyMember]= @id";
        public static string VisitUpdate => "update [dbo].[VisitingMedicalFacility] set DateAndTime = @DateAndTime, Summ=@Summ, IdContract=@IdContract, IdFamilyMember=@IdFamilyMember where [IdFamilyMember]= @id";
        #endregion

        #region insert
        public static string CreaturesTypesInsert => "insert into [dbo].[CreatureType] VALUES(@name) select cast(SCOPE_IDENTITY() as int)";
        public static string AnalysisTypesInsert => "insert into [dbo].[AnalysisType] VALUES(@name) select cast(SCOPE_IDENTITY() as int)";
        public static string ClinicsInsert => "insert into [dbo].[Clinic] VALUES(@name,@phone,@address) select cast(SCOPE_IDENTITY() as int)";
        public static string ExaminationTypesInsert => "insert into [dbo].[ExaminationType] VALUES(@name) select cast(SCOPE_IDENTITY() as int)";
        public static string MedicalFieldsInsert => "insert into [dbo].[MedicalField] VALUES(@name) select cast(SCOPE_IDENTITY() as int)";
        public static string MedicinesInsert => "insert into [dbo].[Medicines] VALUES(@name,@cost,@InstructionsForUse) select cast(SCOPE_IDENTITY() as int)";
        public static string FamilyMemberInsert => "insert into [dbo].[FamilyMember] VALUES(@fullName,@dateOfBirth,@idCreatureType) select cast(SCOPE_IDENTITY() as int)";
        public static string VisitInsert => "insert into [dbo].[VisitingMedicalFacility] (DateAndTime,IdContract,IdFamilyMember) VALUES(@DateAndTime,@IdContract,@IdFamilyMember) select cast(SCOPE_IDENTITY() as int)";
        #endregion

        public static string VisitDoctorforMedicalField => "EXEC VisitDoctorforMedicalField @name, @medicFieldName";
        public static string AnalysesForPeriod => "EXEC AnalysesForPeriod @name, @date1, @date2, @analysisTypeName ";
        public static string AnalysisSelect => "select ant.Name [Тип анализа], al.HasDeviation[Отклонения], al.FileLink[Ссылка на файл] from [dbo].[Analysis] al join [dbo].[AnalysisType] ant on ant.IdAnalysisType = al.IdAnalysisType where al.IdVisit = @idVisit";
        public static string ReportSelect => "select mr.Diagnosis[Диагноз], mr.FileLink[Ссылка на файл], mf.Name[Мед.область], et.Name[Обследование] from [dbo].[MedicalReport] mr join [dbo].[ExaminationType] et on mr.IdExaminationType = et.IdExaminationType join[dbo].[MedicalField] mf on mr.IdMedicalField = mf.IdMedicalField where mr.IdVisit = @idVisit";
        
        public static string ComboBoxFamilyMember => "select FullName from [dbo].[FamilyMember] order by FullName";
        public static string ComboBoxMedicalField => "select Name from [dbo].[MedicalField] order by Name";
        public static string ComboBoxAnalysisType => "select Name from [dbo].[AnalysisType] order by Name";

    }
}
