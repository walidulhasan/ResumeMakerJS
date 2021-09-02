angular.module("ResumeApp")
    /*FactoryUse*/
    .factory('apiService', function ($http) {
        return {
            get: function(u) {
                return $http({
                    url: u,
                    method: 'GET'
                });
            },
            getById: function(u, id) {
                return $http({
                    url: `u${id}`,
                    method: 'GET'
                });
            },
            post: function(u, d) {
                return $http({
                    url: u,
                    method: 'POST',
                    data: d
                });
            },
            put: function(u, d) {
                return $http({
                    url: u,
                    method: 'PUT',
                    data: d
                });
            },
            delete: function(u, id) {
                console.log(`${u}${id}`);
                return $http({
                    url: `${u}${id}`,
                    method: 'DELETE'
                });
                
            },
        }
    });