angular.module("umbraco").controller("Preflight.Dashboard.Controller", ['$scope', '$http', '$timeout', '$q', 'notificationsService', function ($scope, $http, $timeout, $q, notificationsService) {

    $scope.groups = [];

    $http.get('/umbraco/BackOffice/Api/Preflight/GetChecks').success(function(r) {

        $scope.groups = r;

    });

    console.log(notificationsService);

    $scope.doCheck = function (group, check) {

        $http.get('/umbraco/BackOffice/Api/Preflight/GetCheckResult?groupAlias=' + group.alias + '&id=' + check.id).success(function (r) {

            console.log(r);

            if (r.status == 0) {
                notificationsService.success('Passed check (' + check.name + ')', r.message);
            } else if (r.status == 1) {
                notificationsService.warning('Almost passed check #H5IS', r.message);
            } else if (r.status == 2) {
                notificationsService.error('Failed check (' + check.name + ')', r.message);
            }

        });

    };

}]);