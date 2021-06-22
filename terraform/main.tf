terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}
provider "azurerm" {
    features {}
}
variable "services" {
  description = "List of web apps"
  type        = map
  default     = {
    frontend = {
      name="frontend"
    },
    serviceone = {
      name="randletters"
    },
    servicetwo = {
      name="randnumbers"
    },
    servicethree = {
      name="merge"
    },
  }
}
resource "azurerm_resource_group" "rg" {
    name     = "wamdahhassan-rg"
    location = "uksouth"
}
resource "azurerm_app_service_plan" "sp"{
    name="wamdah-app-svc"
    kind="Windows"
    sku {
        tier = "Basic"
        size = "B1"
    }
  
  resource_group_name=azurerm_resource_group.rg.name
  location=azurerm_resource_group.rg.location    
}
    resource "azurerm_app_service" "webapp" {
    name="wamdahhassan-frontend-service"
    resource_group_name=azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.sp.id
    }
    resource "azurerm_app_service" "webapp1" {
    name="wamdahhassan-merge-service"
    resource_group_name=azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.sp.id
    }
    resource "azurerm_app_service" "webapp2" {
    name="wamdahhassan-randnumbers-service"
    resource_group_name=azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.sp.id
    }
    resource "azurerm_app_service" "webapp3" {
    name="wamdahhassan-randletters-service"
    resource_group_name=azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.sp.id
}