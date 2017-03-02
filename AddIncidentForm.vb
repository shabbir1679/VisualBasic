#Regions " IMPORTS "
Imports System.Data
Imports System.Data.SqlClient
#End Region


Public Class AddIncidentForm

  Dim blnIsDirty As Boolean = False
  
#Region " Form Load "

  Private Sub AddIncidentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Assigning the form Dirty
    blnIsDirty = True
    
    ' Focussing on the cancel Button
    cmdcancel.Focus()
  End Sub
  
 #Region " FORM UNLOAD "
    Private Sub AddIncidentForm_FormClosing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      If blnIsDirty = True Then
        If MessageBox.Show("Are you sure you want to cancel?" , " Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
          e.cancel = True
        End If
      End If
    End Sub
 #End Region
 
