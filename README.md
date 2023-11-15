# Kernel-Memory-Azure-Function-Implementation

Important things to note:
- This example is set up using a Azure Storage Account with a container in it called "output-files".
- In local.settings.json, please add connection strings to a Azure Storage Account, also please configure this on app settings on Azure, mine look like this:

  ![image](https://github.com/Gpadh/Kernel-Memory-Azure-Function-Implementation/assets/55559061/5df131f8-752e-489c-9eae-b7b5bc83a6b1)
- Try triggering the function by blob upload then observe behaviour (breaking case), then uninstall the NuGet packages and trigger it in the same way (working case)


