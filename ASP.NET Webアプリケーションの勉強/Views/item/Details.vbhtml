@ModelType ASP.NET_Webアプリケーションの勉強.t_item
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>t_item</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ItemName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ItemName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.RegistrationDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RegistrationDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
