using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XMLParsingToList.Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Enrollment
    {

        private object sourceField;

        private EnrollmentCase caseField;

        private EnrollmentEmployerConfiguration employerConfigurationField;

        /// <remarks/>
        public object Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCase Case
        {
            get
            {
                return this.caseField;
            }
            set
            {
                this.caseField = value;
            }
        }

        /// <remarks/>
        public EnrollmentEmployerConfiguration EmployerConfiguration
        {
            get
            {
                return this.employerConfigurationField;
            }
            set
            {
                this.employerConfigurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCase
    {

        private string processCaseField;

        private string caseNumberField;

        private System.DateTime caseEffectiveDateField;

        private string gESRField;

        private string piIsPayorField;

        private string situsField;

        private EnrollmentCaseCashWithApplication cashWithApplicationField;

        private object casePlanField;

        private EnrollmentCaseLocation locationField;

        private object manageGIsField;

        private object keyerSheetsField;

        private object quickSheetsField;

        private object caseConfigurationDataField;

        /// <remarks/>
        public string ProcessCase
        {
            get
            {
                return this.processCaseField;
            }
            set
            {
                this.processCaseField = value;
            }
        }

        /// <remarks/>
        public string CaseNumber
        {
            get
            {
                return this.caseNumberField;
            }
            set
            {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CaseEffectiveDate
        {
            get
            {
                return this.caseEffectiveDateField;
            }
            set
            {
                this.caseEffectiveDateField = value;
            }
        }

        /// <remarks/>
        public string GESR
        {
            get
            {
                return this.gESRField;
            }
            set
            {
                this.gESRField = value;
            }
        }

        /// <remarks/>
        public string PiIsPayor
        {
            get
            {
                return this.piIsPayorField;
            }
            set
            {
                this.piIsPayorField = value;
            }
        }

        /// <remarks/>
        public string Situs
        {
            get
            {
                return this.situsField;
            }
            set
            {
                this.situsField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseCashWithApplication CashWithApplication
        {
            get
            {
                return this.cashWithApplicationField;
            }
            set
            {
                this.cashWithApplicationField = value;
            }
        }

        /// <remarks/>
        public object CasePlan
        {
            get
            {
                return this.casePlanField;
            }
            set
            {
                this.casePlanField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocation Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public object ManageGIs
        {
            get
            {
                return this.manageGIsField;
            }
            set
            {
                this.manageGIsField = value;
            }
        }

        /// <remarks/>
        public object KeyerSheets
        {
            get
            {
                return this.keyerSheetsField;
            }
            set
            {
                this.keyerSheetsField = value;
            }
        }

        /// <remarks/>
        public object QuickSheets
        {
            get
            {
                return this.quickSheetsField;
            }
            set
            {
                this.quickSheetsField = value;
            }
        }

        /// <remarks/>
        public object CaseConfigurationData
        {
            get
            {
                return this.caseConfigurationDataField;
            }
            set
            {
                this.caseConfigurationDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseCashWithApplication
    {

        private byte amountField;

        private byte calculatedAmountField;

        private System.DateTime transactionDateField;

        /// <remarks/>
        public byte Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public byte CalculatedAmount
        {
            get
            {
                return this.calculatedAmountField;
            }
            set
            {
                this.calculatedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TransactionDate
        {
            get
            {
                return this.transactionDateField;
            }
            set
            {
                this.transactionDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocation
    {

        private string locationTypeField;

        private EnrollmentCaseLocationAddress addressField;

        private byte callCenterField;

        private byte signatureRequiredField;

        private byte applicationCountField;

        private EnrollmentCaseLocationApplication applicationField;

        private byte genelcoLocationField;

        /// <remarks/>
        public string LocationType
        {
            get
            {
                return this.locationTypeField;
            }
            set
            {
                this.locationTypeField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public byte CallCenter
        {
            get
            {
                return this.callCenterField;
            }
            set
            {
                this.callCenterField = value;
            }
        }

        /// <remarks/>
        public byte SignatureRequired
        {
            get
            {
                return this.signatureRequiredField;
            }
            set
            {
                this.signatureRequiredField = value;
            }
        }

        /// <remarks/>
        public byte ApplicationCount
        {
            get
            {
                return this.applicationCountField;
            }
            set
            {
                this.applicationCountField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplication Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        /// <remarks/>
        public byte GenelcoLocation
        {
            get
            {
                return this.genelcoLocationField;
            }
            set
            {
                this.genelcoLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationAddress
    {

        private string cityField;

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplication
    {

        private EnrollmentCaseLocationApplicationPerson[] peopleField;

        private EnrollmentCaseLocationApplicationPolicies policiesField;

        private EnrollmentCaseLocationApplicationPayDetail payDetailField;

        private System.DateTime dateSignedField;

        private System.DateTime eOIDateSignedField;

        private string enrollmentIndicatorField;

        private uint payorNumberField;

        private EnrollmentCaseLocationApplicationAgent[] agentsField;

        private object nAICFormsField;

        private EnrollmentCaseLocationApplicationApplicantSignature applicantSignatureField;

        private EnrollmentCaseLocationApplicationApplicantSignature2 applicantSignature2Field;

        private EnrollmentCaseLocationApplicationGroupApplicantSignature groupApplicantSignatureField;

        private EnrollmentCaseLocationApplicationApplicantSignatureDI5_Employee applicantSignatureDI5_EmployeeField;

        private EnrollmentCaseLocationApplicationApplicantSignatureDI5_Agent applicantSignatureDI5_AgentField;

        private System.DateTime requestedIssueDateField;

        private System.DateTime fileIssueDateField;

        private string recordTypeField;

        private EnrollmentCaseLocationApplicationSupplementalData supplementalDataField;

        private object supplementalFormField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Person", IsNullable = false)]
        public EnrollmentCaseLocationApplicationPerson[] People
        {
            get
            {
                return this.peopleField;
            }
            set
            {
                this.peopleField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPolicies Policies
        {
            get
            {
                return this.policiesField;
            }
            set
            {
                this.policiesField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPayDetail PayDetail
        {
            get
            {
                return this.payDetailField;
            }
            set
            {
                this.payDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateSigned
        {
            get
            {
                return this.dateSignedField;
            }
            set
            {
                this.dateSignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime EOIDateSigned
        {
            get
            {
                return this.eOIDateSignedField;
            }
            set
            {
                this.eOIDateSignedField = value;
            }
        }

        /// <remarks/>
        public string EnrollmentIndicator
        {
            get
            {
                return this.enrollmentIndicatorField;
            }
            set
            {
                this.enrollmentIndicatorField = value;
            }
        }

        /// <remarks/>
        public uint PayorNumber
        {
            get
            {
                return this.payorNumberField;
            }
            set
            {
                this.payorNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Agent", IsNullable = false)]
        public EnrollmentCaseLocationApplicationAgent[] Agents
        {
            get
            {
                return this.agentsField;
            }
            set
            {
                this.agentsField = value;
            }
        }

        /// <remarks/>
        public object NAICForms
        {
            get
            {
                return this.nAICFormsField;
            }
            set
            {
                this.nAICFormsField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignature ApplicantSignature
        {
            get
            {
                return this.applicantSignatureField;
            }
            set
            {
                this.applicantSignatureField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignature2 ApplicantSignature2
        {
            get
            {
                return this.applicantSignature2Field;
            }
            set
            {
                this.applicantSignature2Field = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationGroupApplicantSignature GroupApplicantSignature
        {
            get
            {
                return this.groupApplicantSignatureField;
            }
            set
            {
                this.groupApplicantSignatureField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignatureDI5_Employee ApplicantSignatureDI5_Employee
        {
            get
            {
                return this.applicantSignatureDI5_EmployeeField;
            }
            set
            {
                this.applicantSignatureDI5_EmployeeField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignatureDI5_Agent ApplicantSignatureDI5_Agent
        {
            get
            {
                return this.applicantSignatureDI5_AgentField;
            }
            set
            {
                this.applicantSignatureDI5_AgentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime RequestedIssueDate
        {
            get
            {
                return this.requestedIssueDateField;
            }
            set
            {
                this.requestedIssueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FileIssueDate
        {
            get
            {
                return this.fileIssueDateField;
            }
            set
            {
                this.fileIssueDateField = value;
            }
        }

        /// <remarks/>
        public string RecordType
        {
            get
            {
                return this.recordTypeField;
            }
            set
            {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationSupplementalData SupplementalData
        {
            get
            {
                return this.supplementalDataField;
            }
            set
            {
                this.supplementalDataField = value;
            }
        }

        /// <remarks/>
        public object SupplementalForm
        {
            get
            {
                return this.supplementalFormField;
            }
            set
            {
                this.supplementalFormField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPerson
    {

        private string isProposedInsuredField;

        private string isPolicyOwnerField;

        private string isPayorField;

        private string isSecondaryContactField;

        private string isDependentField;

        private string isBeneficiaryField;

        private string isEmployeeField;

        private string relationshipToPIField;

        private string relationshipToEmployeeField;

        private EnrollmentCaseLocationApplicationPersonName nameField;

        private EnrollmentCaseLocationApplicationPersonAddress addressField;

        private string genderField;

        private string groupNumberField;

        private System.DateTime dateOfBirthField;

        private bool dateOfBirthFieldSpecified;

        private byte ageField;

        private bool ageFieldSpecified;

        private uint sSNField;

        private string maritalStatusField;

        private string employerField;

        private uint crossReferenceField;

        private EnrollmentCaseLocationApplicationPersonQuestion[] questionnaireField;

        private object resultsField;

        private object resultsEOIRequiredField;

        private object existingCoverageField;

        private EnrollmentCaseLocationApplicationPersonEmployee employeeField;

        /// <remarks/>
        public string IsProposedInsured
        {
            get
            {
                return this.isProposedInsuredField;
            }
            set
            {
                this.isProposedInsuredField = value;
            }
        }

        /// <remarks/>
        public string IsPolicyOwner
        {
            get
            {
                return this.isPolicyOwnerField;
            }
            set
            {
                this.isPolicyOwnerField = value;
            }
        }

        /// <remarks/>
        public string IsPayor
        {
            get
            {
                return this.isPayorField;
            }
            set
            {
                this.isPayorField = value;
            }
        }

        /// <remarks/>
        public string IsSecondaryContact
        {
            get
            {
                return this.isSecondaryContactField;
            }
            set
            {
                this.isSecondaryContactField = value;
            }
        }

        /// <remarks/>
        public string IsDependent
        {
            get
            {
                return this.isDependentField;
            }
            set
            {
                this.isDependentField = value;
            }
        }

        /// <remarks/>
        public string IsBeneficiary
        {
            get
            {
                return this.isBeneficiaryField;
            }
            set
            {
                this.isBeneficiaryField = value;
            }
        }

        /// <remarks/>
        public string IsEmployee
        {
            get
            {
                return this.isEmployeeField;
            }
            set
            {
                this.isEmployeeField = value;
            }
        }

        /// <remarks/>
        public string RelationshipToPI
        {
            get
            {
                return this.relationshipToPIField;
            }
            set
            {
                this.relationshipToPIField = value;
            }
        }

        /// <remarks/>
        public string RelationshipToEmployee
        {
            get
            {
                return this.relationshipToEmployeeField;
            }
            set
            {
                this.relationshipToEmployeeField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPersonName Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPersonAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public string GroupNumber
        {
            get
            {
                return this.groupNumberField;
            }
            set
            {
                this.groupNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfBirthSpecified
        {
            get
            {
                return this.dateOfBirthFieldSpecified;
            }
            set
            {
                this.dateOfBirthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified
        {
            get
            {
                return this.ageFieldSpecified;
            }
            set
            {
                this.ageFieldSpecified = value;
            }
        }

        /// <remarks/>
        public uint SSN
        {
            get
            {
                return this.sSNField;
            }
            set
            {
                this.sSNField = value;
            }
        }

        /// <remarks/>
        public string MaritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        public string Employer
        {
            get
            {
                return this.employerField;
            }
            set
            {
                this.employerField = value;
            }
        }

        /// <remarks/>
        public uint CrossReference
        {
            get
            {
                return this.crossReferenceField;
            }
            set
            {
                this.crossReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Question", IsNullable = false)]
        public EnrollmentCaseLocationApplicationPersonQuestion[] Questionnaire
        {
            get
            {
                return this.questionnaireField;
            }
            set
            {
                this.questionnaireField = value;
            }
        }

        /// <remarks/>
        public object Results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        public object ResultsEOIRequired
        {
            get
            {
                return this.resultsEOIRequiredField;
            }
            set
            {
                this.resultsEOIRequiredField = value;
            }
        }

        /// <remarks/>
        public object ExistingCoverage
        {
            get
            {
                return this.existingCoverageField;
            }
            set
            {
                this.existingCoverageField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPersonEmployee Employee
        {
            get
            {
                return this.employeeField;
            }
            set
            {
                this.employeeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPersonName
    {

        private string firstNameField;

        private string lastNameField;

        private string fullNameField;

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public string FullName
        {
            get
            {
                return this.fullNameField;
            }
            set
            {
                this.fullNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPersonAddress
    {

        private string streetAddress1Field;

        private string cityField;

        private string stateField;

        private ushort zipCodeField;

        /// <remarks/>
        public string StreetAddress1
        {
            get
            {
                return this.streetAddress1Field;
            }
            set
            {
                this.streetAddress1Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public ushort ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPersonQuestion
    {

        private byte questionNumberField;

        private string questionNumberTextField;

        private string yesNoField;

        private string remarkField;

        private object tobaccoUseField;

        /// <remarks/>
        public byte QuestionNumber
        {
            get
            {
                return this.questionNumberField;
            }
            set
            {
                this.questionNumberField = value;
            }
        }

        /// <remarks/>
        public string QuestionNumberText
        {
            get
            {
                return this.questionNumberTextField;
            }
            set
            {
                this.questionNumberTextField = value;
            }
        }

        /// <remarks/>
        public string YesNo
        {
            get
            {
                return this.yesNoField;
            }
            set
            {
                this.yesNoField = value;
            }
        }

        /// <remarks/>
        public string Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                this.remarkField = value;
            }
        }

        /// <remarks/>
        public object TobaccoUse
        {
            get
            {
                return this.tobaccoUseField;
            }
            set
            {
                this.tobaccoUseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPersonEmployee
    {

        private string employerField;

        private ushort annualCompensationField;

        private object payScheduleField;

        private byte contributionScheduleField;

        private ushort monthlySalaryField;

        private uint employeeNumberField;

        private System.DateTime dateOfHireField;

        /// <remarks/>
        public string Employer
        {
            get
            {
                return this.employerField;
            }
            set
            {
                this.employerField = value;
            }
        }

        /// <remarks/>
        public ushort AnnualCompensation
        {
            get
            {
                return this.annualCompensationField;
            }
            set
            {
                this.annualCompensationField = value;
            }
        }

        /// <remarks/>
        public object PaySchedule
        {
            get
            {
                return this.payScheduleField;
            }
            set
            {
                this.payScheduleField = value;
            }
        }

        /// <remarks/>
        public byte ContributionSchedule
        {
            get
            {
                return this.contributionScheduleField;
            }
            set
            {
                this.contributionScheduleField = value;
            }
        }

        /// <remarks/>
        public ushort MonthlySalary
        {
            get
            {
                return this.monthlySalaryField;
            }
            set
            {
                this.monthlySalaryField = value;
            }
        }

        /// <remarks/>
        public uint EmployeeNumber
        {
            get
            {
                return this.employeeNumberField;
            }
            set
            {
                this.employeeNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateOfHire
        {
            get
            {
                return this.dateOfHireField;
            }
            set
            {
                this.dateOfHireField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPolicies
    {

        private EnrollmentCaseLocationApplicationPoliciesPolicy policyField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPoliciesPolicy Policy
        {
            get
            {
                return this.policyField;
            }
            set
            {
                this.policyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPoliciesPolicy
    {

        private string planCodeField;

        private decimal baseUnitsField;

        private byte policyUnitsField;

        private string coverageLevelField;

        private string section125Field;

        private string existingCOIC2Field;

        private string isHSAField;

        private string issueTypeField;

        private byte faceAmountField;

        private byte requestedFaceAmountField;

        private ushort monthlySalaryField;

        private string formNameField;

        private EnrollmentCaseLocationApplicationPoliciesPolicyRider[] riderField;

        private decimal perDeductionField;

        private EnrollmentCaseLocationApplicationPoliciesPolicyPolicyBeneficiary policyBeneficiaryField;

        private EnrollmentCaseLocationApplicationPoliciesPolicyReplaceCoverage replaceCoverageField;

        private string recordTypeField;

        private object groupProductField;

        private object groupExistField;

        private System.DateTime terminationDateField;

        private string occClassField;

        private byte isFixedAmountRequiredField;

        private byte spouseFaceAmountField;

        private byte childFaceAmountField;

        private string situsField;

        private byte empTakeoverAmountLimitField;

        private byte spouseTakeoverAmountLimitField;

        private byte childTakeoverAmountLimitField;

        private object policyDataField;

        /// <remarks/>
        public string PlanCode
        {
            get
            {
                return this.planCodeField;
            }
            set
            {
                this.planCodeField = value;
            }
        }

        /// <remarks/>
        public decimal BaseUnits
        {
            get
            {
                return this.baseUnitsField;
            }
            set
            {
                this.baseUnitsField = value;
            }
        }

        /// <remarks/>
        public byte PolicyUnits
        {
            get
            {
                return this.policyUnitsField;
            }
            set
            {
                this.policyUnitsField = value;
            }
        }

        /// <remarks/>
        public string CoverageLevel
        {
            get
            {
                return this.coverageLevelField;
            }
            set
            {
                this.coverageLevelField = value;
            }
        }

        /// <remarks/>
        public string Section125
        {
            get
            {
                return this.section125Field;
            }
            set
            {
                this.section125Field = value;
            }
        }

        /// <remarks/>
        public string ExistingCOIC2
        {
            get
            {
                return this.existingCOIC2Field;
            }
            set
            {
                this.existingCOIC2Field = value;
            }
        }

        /// <remarks/>
        public string IsHSA
        {
            get
            {
                return this.isHSAField;
            }
            set
            {
                this.isHSAField = value;
            }
        }

        /// <remarks/>
        public string IssueType
        {
            get
            {
                return this.issueTypeField;
            }
            set
            {
                this.issueTypeField = value;
            }
        }

        /// <remarks/>
        public byte FaceAmount
        {
            get
            {
                return this.faceAmountField;
            }
            set
            {
                this.faceAmountField = value;
            }
        }

        /// <remarks/>
        public byte RequestedFaceAmount
        {
            get
            {
                return this.requestedFaceAmountField;
            }
            set
            {
                this.requestedFaceAmountField = value;
            }
        }

        /// <remarks/>
        public ushort MonthlySalary
        {
            get
            {
                return this.monthlySalaryField;
            }
            set
            {
                this.monthlySalaryField = value;
            }
        }

        /// <remarks/>
        public string FormName
        {
            get
            {
                return this.formNameField;
            }
            set
            {
                this.formNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rider")]
        public EnrollmentCaseLocationApplicationPoliciesPolicyRider[] Rider
        {
            get
            {
                return this.riderField;
            }
            set
            {
                this.riderField = value;
            }
        }

        /// <remarks/>
        public decimal PerDeduction
        {
            get
            {
                return this.perDeductionField;
            }
            set
            {
                this.perDeductionField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPoliciesPolicyPolicyBeneficiary PolicyBeneficiary
        {
            get
            {
                return this.policyBeneficiaryField;
            }
            set
            {
                this.policyBeneficiaryField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationPoliciesPolicyReplaceCoverage ReplaceCoverage
        {
            get
            {
                return this.replaceCoverageField;
            }
            set
            {
                this.replaceCoverageField = value;
            }
        }

        /// <remarks/>
        public string RecordType
        {
            get
            {
                return this.recordTypeField;
            }
            set
            {
                this.recordTypeField = value;
            }
        }

        /// <remarks/>
        public object GroupProduct
        {
            get
            {
                return this.groupProductField;
            }
            set
            {
                this.groupProductField = value;
            }
        }

        /// <remarks/>
        public object GroupExist
        {
            get
            {
                return this.groupExistField;
            }
            set
            {
                this.groupExistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime TerminationDate
        {
            get
            {
                return this.terminationDateField;
            }
            set
            {
                this.terminationDateField = value;
            }
        }

        /// <remarks/>
        public string OccClass
        {
            get
            {
                return this.occClassField;
            }
            set
            {
                this.occClassField = value;
            }
        }

        /// <remarks/>
        public byte IsFixedAmountRequired
        {
            get
            {
                return this.isFixedAmountRequiredField;
            }
            set
            {
                this.isFixedAmountRequiredField = value;
            }
        }

        /// <remarks/>
        public byte SpouseFaceAmount
        {
            get
            {
                return this.spouseFaceAmountField;
            }
            set
            {
                this.spouseFaceAmountField = value;
            }
        }

        /// <remarks/>
        public byte ChildFaceAmount
        {
            get
            {
                return this.childFaceAmountField;
            }
            set
            {
                this.childFaceAmountField = value;
            }
        }

        /// <remarks/>
        public string Situs
        {
            get
            {
                return this.situsField;
            }
            set
            {
                this.situsField = value;
            }
        }

        /// <remarks/>
        public byte EmpTakeoverAmountLimit
        {
            get
            {
                return this.empTakeoverAmountLimitField;
            }
            set
            {
                this.empTakeoverAmountLimitField = value;
            }
        }

        /// <remarks/>
        public byte SpouseTakeoverAmountLimit
        {
            get
            {
                return this.spouseTakeoverAmountLimitField;
            }
            set
            {
                this.spouseTakeoverAmountLimitField = value;
            }
        }

        /// <remarks/>
        public byte ChildTakeoverAmountLimit
        {
            get
            {
                return this.childTakeoverAmountLimitField;
            }
            set
            {
                this.childTakeoverAmountLimitField = value;
            }
        }

        /// <remarks/>
        public object PolicyData
        {
            get
            {
                return this.policyDataField;
            }
            set
            {
                this.policyDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPoliciesPolicyRider
    {

        private string riderCodeField;

        private decimal riderUnitsField;

        private object riderAgentsField;

        /// <remarks/>
        public string RiderCode
        {
            get
            {
                return this.riderCodeField;
            }
            set
            {
                this.riderCodeField = value;
            }
        }

        /// <remarks/>
        public decimal RiderUnits
        {
            get
            {
                return this.riderUnitsField;
            }
            set
            {
                this.riderUnitsField = value;
            }
        }

        /// <remarks/>
        public object RiderAgents
        {
            get
            {
                return this.riderAgentsField;
            }
            set
            {
                this.riderAgentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPoliciesPolicyPolicyBeneficiary
    {

        private uint crossReferenceField;

        private string beneficiaryTypeField;

        private byte beneficiaryPercentField;

        /// <remarks/>
        public uint CrossReference
        {
            get
            {
                return this.crossReferenceField;
            }
            set
            {
                this.crossReferenceField = value;
            }
        }

        /// <remarks/>
        public string BeneficiaryType
        {
            get
            {
                return this.beneficiaryTypeField;
            }
            set
            {
                this.beneficiaryTypeField = value;
            }
        }

        /// <remarks/>
        public byte BeneficiaryPercent
        {
            get
            {
                return this.beneficiaryPercentField;
            }
            set
            {
                this.beneficiaryPercentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPoliciesPolicyReplaceCoverage
    {

        private byte benefitAmountField;

        /// <remarks/>
        public byte BenefitAmount
        {
            get
            {
                return this.benefitAmountField;
            }
            set
            {
                this.benefitAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationPayDetail
    {

        private System.DateTime dateOfFirstDeductionField;

        private decimal totalPremiumField;

        private byte numberOfPaysField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DateOfFirstDeduction
        {
            get
            {
                return this.dateOfFirstDeductionField;
            }
            set
            {
                this.dateOfFirstDeductionField = value;
            }
        }

        /// <remarks/>
        public decimal TotalPremium
        {
            get
            {
                return this.totalPremiumField;
            }
            set
            {
                this.totalPremiumField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfPays
        {
            get
            {
                return this.numberOfPaysField;
            }
            set
            {
                this.numberOfPaysField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgent
    {

        private string aHLAgentCodeField;

        private byte percentageField;

        private string capacityField;

        private object nameField;

        private EnrollmentCaseLocationApplicationAgentAgentSignature agentSignatureField;

        private EnrollmentCaseLocationApplicationAgentAgentSignature2 agentSignature2Field;

        private EnrollmentCaseLocationApplicationAgentAgentSignatureGroup agentSignatureGroupField;

        /// <remarks/>
        public string AHLAgentCode
        {
            get
            {
                return this.aHLAgentCodeField;
            }
            set
            {
                this.aHLAgentCodeField = value;
            }
        }

        /// <remarks/>
        public byte Percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }

        /// <remarks/>
        public string Capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        /// <remarks/>
        public object Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationAgentAgentSignature AgentSignature
        {
            get
            {
                return this.agentSignatureField;
            }
            set
            {
                this.agentSignatureField = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationAgentAgentSignature2 AgentSignature2
        {
            get
            {
                return this.agentSignature2Field;
            }
            set
            {
                this.agentSignature2Field = value;
            }
        }

        /// <remarks/>
        public EnrollmentCaseLocationApplicationAgentAgentSignatureGroup AgentSignatureGroup
        {
            get
            {
                return this.agentSignatureGroupField;
            }
            set
            {
                this.agentSignatureGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgentAgentSignature
    {

        private EnrollmentCaseLocationApplicationAgentAgentSignatureSigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationAgentAgentSignatureSigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgentAgentSignatureSigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgentAgentSignature2
    {

        private EnrollmentCaseLocationApplicationAgentAgentSignature2SigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationAgentAgentSignature2SigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgentAgentSignature2SigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgentAgentSignatureGroup
    {

        private EnrollmentCaseLocationApplicationAgentAgentSignatureGroupSigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationAgentAgentSignatureGroupSigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationAgentAgentSignatureGroupSigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignature
    {

        private EnrollmentCaseLocationApplicationApplicantSignatureSigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignatureSigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignatureSigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignature2
    {

        private EnrollmentCaseLocationApplicationApplicantSignature2SigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignature2SigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignature2SigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationGroupApplicantSignature
    {

        private EnrollmentCaseLocationApplicationGroupApplicantSignatureSigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationGroupApplicantSignatureSigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationGroupApplicantSignatureSigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignatureDI5_Employee
    {

        private EnrollmentCaseLocationApplicationApplicantSignatureDI5_EmployeeSigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignatureDI5_EmployeeSigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignatureDI5_EmployeeSigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignatureDI5_Agent
    {

        private EnrollmentCaseLocationApplicationApplicantSignatureDI5_AgentSigPlus sigPlusField;

        /// <remarks/>
        public EnrollmentCaseLocationApplicationApplicantSignatureDI5_AgentSigPlus SigPlus
        {
            get
            {
                return this.sigPlusField;
            }
            set
            {
                this.sigPlusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationApplicantSignatureDI5_AgentSigPlus
    {

        private object signatureStringField;

        /// <remarks/>
        public object SignatureString
        {
            get
            {
                return this.signatureStringField;
            }
            set
            {
                this.signatureStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentCaseLocationApplicationSupplementalData
    {

        private object supplementalDataTagTypeField;

        /// <remarks/>
        public object SupplementalDataTagType
        {
            get
            {
                return this.supplementalDataTagTypeField;
            }
            set
            {
                this.supplementalDataTagTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EnrollmentEmployerConfiguration
    {

        private object addressField;

        private object billingConfigurationsField;

        private object locationConfigurationsField;

        private object classesField;

        private object productConfigurationsField;

        private object agentOfRecordField;

        private object servicingAgentField;

        private object otherAgentsField;

        /// <remarks/>
        public object Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public object BillingConfigurations
        {
            get
            {
                return this.billingConfigurationsField;
            }
            set
            {
                this.billingConfigurationsField = value;
            }
        }

        /// <remarks/>
        public object LocationConfigurations
        {
            get
            {
                return this.locationConfigurationsField;
            }
            set
            {
                this.locationConfigurationsField = value;
            }
        }

        /// <remarks/>
        public object Classes
        {
            get
            {
                return this.classesField;
            }
            set
            {
                this.classesField = value;
            }
        }

        /// <remarks/>
        public object ProductConfigurations
        {
            get
            {
                return this.productConfigurationsField;
            }
            set
            {
                this.productConfigurationsField = value;
            }
        }

        /// <remarks/>
        public object AgentOfRecord
        {
            get
            {
                return this.agentOfRecordField;
            }
            set
            {
                this.agentOfRecordField = value;
            }
        }

        /// <remarks/>
        public object ServicingAgent
        {
            get
            {
                return this.servicingAgentField;
            }
            set
            {
                this.servicingAgentField = value;
            }
        }

        /// <remarks/>
        public object OtherAgents
        {
            get
            {
                return this.otherAgentsField;
            }
            set
            {
                this.otherAgentsField = value;
            }
        }
    }

}