# Bangazon E-Commerce Site


## Overview

It's time to build Bangazon's flagship product-- our customer-facing e-commerce platform! This application will be like a cross between Amazon and Etsy. Users will be able to post products for sale and purchase products. _Be sure to read the project requirements very carefully for this sprint._


## Setup

1. One person from your group should create a team on GitHub classroom
1. On that process is complete and the repository is created, everyone else joins their team.
1. Everyone should clone the repository to their machine.

## Making your Database
1. Everyone on your team should create a new database called `BangazonSite`.
1. It should already be linked in your `appsettings.json` file.

## Boilerplate Code
1. In your `Models` directory, you should see a model for `ApplicationUser` and `Product`.
1. We went ahead and overrode the default `IdentityUser` with your new `ApplicationUser`, so your authentication scheme is ready to go.
1. You already have a migration in your migration folder that will build your database. You don't need to add a new one until you make changes to your models or add seed data. To build your database at the beginning of your project, you just need to run `Update-Database`.

## Making your Models
*The entire team should make your models together. This is a group activity. One person should type and the rest of the team should inform the decisions.*
1. After you've read the tickets carefully and asked clarifying questions, you can make the rest of your models. You will need models for all of your join tables.
1. All of the models should be made on one branch with the entire team's input.
1. If you want seed data in your project, now is the time to add it into `ApplicationDbContext`.
1. When you're done with your models, ask an instructor to check them for you _before_ you run a migration.
1. On the same branch where you made your models, run the command `Add-Migration BuildTables`.
1. Run the command `Update-Database` and examine your database to make sure it worked. If anything in your database looks unexpected, _ask for help before you do anything else_.
1. Add and commit on that branch. Put up a PR that includes all of your models and the migration to build your tables.
1. Once the PR is approved and merged, everyone in your group should pull down the new master and run `Update-Database`. The team members who pull down the code _do not_ need to add a new migration-- they can run the one that was already created.


## References for Tickets

### Grouped Products by Product Type

One of the features you need to implement is a view that displays all of the product types as headers, with the first three products in that type listed beneath it. We are providing you a LINQ statement that will get you started.

Whomever tackles that ticket, this is the method that you will need to add to your `ProductsController.cs`.

```cs
public async Task<IActionResult> Types()
{
    var model = new ProductTypesViewModel();

    // Build list of Product instances for display in view
    // LINQ is awesome
    model.GroupedProducts = await (
        from t in _context.ProductType
        join p in _context.Product
        on t.ProductTypeId equals p.ProductTypeId
        group new { t, p } by new { t.ProductTypeId, t.Label } into grouped
        select new GroupedProducts
        {
            TypeId = grouped.Key.ProductTypeId,
            TypeName = grouped.Key.Label,
            ProductCount = grouped.Select(x => x.p.ProductId).Count(),
            Products = grouped.Select(x => x.p).Take(3)
        }).ToListAsync();

    return View(model);
}
```

In addition to that, add the following custom route to the bottom of your `Startup.cs` file.

```cs
routes.MapRoute ("types", "types",
    defaults : new { controller = "Products", action = "Types" });
```

## Removing Items from Model Validation

One of the features you must implement is allowing customers to add products to sell. You'll need to remove the user from model validation to get it to work. Here's an example of something your team will need to do in `Create()` method in **`ProductsController`**.

```cs
// Remove the userId from the model validation because it is
// not information posted in the form
ModelState.Remove("product.UserId");
```
