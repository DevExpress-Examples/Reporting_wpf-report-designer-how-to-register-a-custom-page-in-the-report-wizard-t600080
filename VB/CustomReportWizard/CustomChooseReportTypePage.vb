Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.Entity.ProjectModel
Imports DevExpress.XtraReports.Wizards
Imports DevExpress.XtraReports.Wizards.Presenters
Imports DevExpress.XtraReports.Wizards.Views
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomReportWizard
    Friend Class CustomChooseReportTypePage
        Inherits ChooseReportTypePage(Of XtraReportModel)

        Public Sub New(ByVal view As IChooseReportTypePageView, ByVal dataConnections As IEnumerable(Of SqlDataConnection), ByVal dataSourceTypes As DataSourceTypes, ByVal context As IWizardRunnerContext, ByVal solutionTypesProvider As ISolutionTypesProvider)
            MyBase.New(view, dataConnections, dataSourceTypes, context, solutionTypesProvider)
        End Sub

        Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides Function GetNextPageType() As Type
            If View.ReportType = ReportType.Standard OrElse View.ReportType = ReportType.Empty Then
                Return GetType(ChoosePageSettingsPage(Of CustomReportModel))
            End If
            Return MyBase.GetNextPageType()
        End Function
    End Class
End Namespace
