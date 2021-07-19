using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrelloApi
{
    public class WorkspaceRequests : BaseRequest
    {
        public void DeleteWorkspace(string workspaceName)
        {
            var getRequest = new WorkspaceRequests();
            var deleteWorkspaceRequest = CreateRequest("organizations", getRequest.GetSpecificWorkspace(workspaceName).Name, Method.DELETE);
            BaseRestClient.Response(deleteWorkspaceRequest);
        }

        public List<WorkspaceProperties> GetWorkspacesNames()
        {
            var getWorkspacesRequest = CreateRequest("Members/me/organizations");
            var restResponse = BaseRestClient.Response(getWorkspacesRequest);
            var response = restResponse.Content;
            return JsonConvert.DeserializeObject<List<WorkspaceProperties>>(response);
        }

        public WorkspaceProperties GetSpecificWorkspace(string workspaceName)
        {
            var getRequest = new WorkspaceRequests();
            return getRequest.GetWorkspacesNames().First(x => x.DisplayName == workspaceName);
        }

        public void CreateWorkSpace(string workspaceName)
        {
            var parameters = new Dictionary<string, string>
            {
                {"displayName", workspaceName },
            };
            var createWorkspaceRequest = CreateRequest("organizations", method: Method.POST, parameters: parameters);
            BaseRestClient.Response(createWorkspaceRequest);
        }
    }
}
