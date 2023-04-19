Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Services.Description
Imports ASP.NET_Webアプリケーションの勉強

Namespace Controllers
    Public Class itemController
        Inherits System.Web.Mvc.Controller

        Private db As New db_SystemEntities
        Private japanese As New My.Resources.Japanese
        ' GET: item

        Function Index() As ActionResult
            ViewBag.japanese = japanese
            Return View(db.t_item.ToList())
        End Function

        ' GET: item/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_item As t_item = db.t_item.Find(id)
            If IsNothing(t_item) Then
                Return HttpNotFound()
            End If
            Return View(t_item)
        End Function

        ' GET: item/Create
        Function Create() As ActionResult
            ViewBag.japanese = japanese
            Return View()
        End Function

        ' POST: item/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,ItemName,RegistrationDate")> ByVal t_item As t_item) As ActionResult
            If ModelState.IsValid Then
                db.t_item.Add(t_item)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(t_item)
        End Function

        ' GET: item/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_item As t_item = db.t_item.Find(id)
            If IsNothing(t_item) Then
                Return HttpNotFound()
            End If
            Return View(t_item)
        End Function

        ' POST: item/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,ItemName,RegistrationDate")> ByVal t_item As t_item) As ActionResult
            If ModelState.IsValid Then
                db.Entry(t_item).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(t_item)
        End Function

        ' GET: item/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim t_item As t_item = db.t_item.Find(id)
            If IsNothing(t_item) Then
                Return HttpNotFound()
            End If
            Return View(t_item)
        End Function

        ' POST: item/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim t_item As t_item = db.t_item.Find(id)
            db.t_item.Remove(t_item)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
